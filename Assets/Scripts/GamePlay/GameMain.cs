using UnityEngine;
using System.Collections;
using SkillSystem;
using Task;
using System.Collections.Generic;

public class GameMain : MonoBehaviour {

    public ws_attackAble_obj obj;
    public ws_attackAble_obj obj2;

     Skill skill = null;

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
        attribute.Value = 10+ obj.obj_entity.Fight;
        //attribute.Effect_EmitParent = obj.Effect_EmitParent;
        //attribute.Effect_EmitName = "ef01";
        //attribute.Effect_HitParent = obj.Effect_HitParent;
        attribute.Effect_HitName = "ef02";
        Attribute attribute2 = new Attribute();
        attribute2.Id = 1;
        attribute2.CostMp = 5;
        attribute2.m_DelayTime = 1;
        attribute2.Mute = mlist;
        attribute2.CD = 3;
        attribute2.AtRound = 1;
        attribute2.Value = 10 + obj2.obj_entity.Fight;
        //attribute2.Effect_EmitParent = obj2.Effect_EmitParent;
        //attribute2.Effect_EmitName = "ef01";
        //attribute2.Effect_HitParent = obj2.Effect_HitParent;
        //attribute2.Effect_HitName = "ef02";




        Entity obj_entity = obj.obj_entity;
        obj_entity.Name = "战舰01";
        obj_entity.Fight = 20;
        Entity obj_entity2 = obj2.obj_entity;
        obj_entity2.Name = "战舰02";
        obj_entity2.Fight = 10; 


        skill = new  Skill();
        skill.Attribute = attribute;
        List<Buff> list = new List<Buff>();
        Buff b = new Buff();
        b.AtRound = 1;
        list.Add(b);

        //obj_entity.AddBuff(skill);
        //obj_entity2.AddBuff(skill);
        skill.Init(obj_entity, obj_entity2, attribute, SkillEnd);
        //检验流程
        bool isvalid = skill.IsValid(new MpVerify());
        if (!isvalid)
        {
            skill.Interrupt(new InterruptValid());
        }
        //StartCoroutine(DoSkill(skill));
        //Fire(skill);
    }

    public IEnumerator DoSkill( Skill s)
    {
        Debug.Log("准备 吟唱");
        Task.TimeCondition cond = new Task.TimeCondition(s.Attribute.m_DelayTime);
        Task.Task task = new Task.Task("吟唱动画", cond);

        yield return s.Sing(task);

        Debug.Log("吟唱 结束");

    }

    public void Fire( Skill skill)
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
    private void HandleCast( Skill skill, int result)
    {
        //释放特效
        Task.Task emitTask = new Task.Task("释放", new CastCondition(skill, 0.5f));
        Task.TaskManager.Instance().AddTask(emitTask);

        //打击效果
        Task.Task hitTask = new Task.Task("打击效果", new HitCondition(skill, 1));
        Task.TaskManager.Instance().AddTask(hitTask);

        ////启动任务队列
        TaskManager.Instance().Start(">>>技能施法流程", delegate ()
        {
            Debug.Log("Hp:" + obj.obj_entity.Hp);
            Debug.Log("Hp2:" + obj2.obj_entity.Hp);
            skill.End();
        });
    }

    public void SkillEnd(SkillSystem.Skill sk)
    {
        Debug.Log("SkillEnd");

    }

    public void Fire02(SkillSystem.Skill skill)
    {
        //to-do吟唱 吟唱时间可以根据表格来
         
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

    public void OnClick()
    {
        Fire(skill); 
    }

}
