using UnityEngine;
using System.Collections;
using Skill;
using Task;
using System.Collections.Generic;

public class GameMain : MonoBehaviour {

    public ws_attackAble_obj obj;
    public ws_attackAble_obj obj2;



    private void Awake()
    {
        List<int> mlist = new List<int>();
        mlist.Add(1);
        Attribute attribute = new Attribute();
        attribute.Id = 1;
        attribute.CostMp = 5;
        attribute.m_DelayTime = 1;
        attribute.Mute = mlist;
        attribute.CD = 3;
        attribute.AtRound = 1;
        attribute.Value = 6;

        Entity obj_entity = obj.obj_entity;
        obj_entity.Name = "战舰01";
        obj_entity.Fight = 20;
        Entity obj_entity2 = new Entity();
        obj_entity2.Name = "战舰02";
        obj_entity2.Fight = 10; 


        Skill.Skill skill = new Skill.Skill();
        skill.Attribute = attribute;
        List<Buff> list = new List<Buff>();
        Buff b = new Buff();
        b.AtRound = 1;
        list.Add(b);

        obj_entity.AddBuff(skill);
        obj_entity2.AddBuff(skill);
        skill.Init(obj_entity, obj_entity2, attribute, SkillEnd);
        //检验流程
        bool isvalid = skill.IsValid(new MpVerify());
        if (!isvalid)
        {
            skill.Interrupt(new InterruptValid());
        }
        //StartCoroutine(DoSkill(skill));
        Fire(skill);
    }

    public IEnumerator DoSkill(Skill.Skill s)
    {
        Debug.Log("准备 吟唱");
        Task.TimeCondition cond = new Task.TimeCondition(s.Attribute.m_DelayTime);
        Task.Task task = new Task.Task("吟唱动画", cond);

        yield return s.Sing(task);

        Debug.Log("吟唱 结束");

    }

    public void Fire(Skill.Skill skill)
    {
        //to-do吟唱 吟唱时间可以根据表格来
        TimeCondition singCond = new TimeCondition(skill.Attribute.m_DelayTime);
        Task.Task singTask = new Task.Task("吟唱任务", singCond);
        TaskManager.Instance().AddTask(singTask);
        //伤害计算
        DamageCondtion dmgCond = new DamageCondtion(skill,
                                                    delegate (int result)
                                                    {
                                                        HandleCast(skill, result);
                                                    },
                                                    EventsType.Skill_EndDmg);
        Task.Task dmgTask = new Task.Task("伤害检查", dmgCond);
        TaskManager.Instance().AddTask(dmgTask);
        //启动任务队列
        TaskManager.Instance().Start(">>>技能伤害计算流程");
    }
    /// <summary>
    /// 处理施法
    /// </summary>
    /// <param name="skill"></param>
    /// <param name="result"></param>
    private void HandleCast(Skill.Skill skill, int result)
    {
        //释放特效
        Task.Task emitTask = new Task.Task("释放", new CastCondition(skill, 0.5f));
        Task.TaskManager.Instance().AddTask(emitTask);

        //打击效果
        //Task.Task hitTask = new Task.Task("打击效果", new HitCondition(skill, 1));
        //Task.TaskManager.Instance().AddTask(hitTask);

        ////启动任务队列
        //TaskManager.Instance().Start(">>>技能施法流程", delegate ()
        //{
        //    skill.End();
        //});
    }

    public void SkillEnd(Skill.Skill sk)
    {
        Debug.Log("SkillEnd");

    }
}
