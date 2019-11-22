using UnityEngine;
using System.Collections;
using Task;
using System.Collections.Generic;
using SkillSystem;

public class ws_battle_ship : ws_fight_obj
{
    protected override void Awake()
    {
        base.Awake();
        obj_entity.Fight = 10;
        obj_entity.Defence = 10;
        obj_entity.Name = "战舰"+ attribute.Name;

        skill = new Skill();
        skill.Attribute = attribute;
        List<Buff> list = new List<Buff>();
        AttributeBuff b = new AttributeBuff();
        b.m_BuffName = "buff001";
        b.m_BuffTime = 5;
        b.m_Fight = 50;
        list.Add(b);
        AttributeBuff b2 = new AttributeBuff();
        b2.m_BuffName = "buff002";
        b2.m_BuffTime = 2;
        b2.m_Fight = 20;
        list.Add(b2);
        skill.Attribute.m_BuffList.AddRange(list);
        obj_entity.AddBuff(b);
        obj_entity.AddBuff(b2);
        sm.InitSkillList();
    }





    public override void Fire(Skill skill)
    { 
        //伤害计算
        DamageCondtion dmgCond = new DamageCondtion(skill,
                                                    delegate (int result)
                                                    {
                                                        HandleCast(skill, result);
                                                    },
                                                    EventsType.Skill_EndDmg);
        Task.Task dmgTask = new Task.Task("伤害检查"+ attribute.Name, dmgCond);
        tm.AddTask(dmgTask);
        //启动任务队列
        tm.Start("技能伤害计算流程"+ attribute.Name, delegate ()
        {
            Debug.Log("Hp:" + obj_entity.Hp);
            skill.End();
        });
    }
    

    /// <summary>
    /// 处理施法
    /// </summary>
    /// <param name="skill"></param>
    /// <param name="result"></param>
    private void HandleCast(Skill skill, int result)
    {
        //释放特效
        Task.Task emitTask = new Task.Task("释放", new CastCondition(skill, 0.5f));
        tm.AddTask(emitTask);

        //打击效果
        Task.Task hitTask = new Task.Task("打击效果", new HitCondition(skill, 1));
        tm.AddTask(hitTask);

        ////启动任务队列
        tm.Start(">>>技能施法流程" + attribute.Name, delegate ()
        {
            Debug.Log("Hp:" + obj_entity.Hp);
            skill.End();
        });
    }

    public override void Fire2(Skill skill)
    {
        //释放特效
        //CastCondition cc = new CastCondition(skill,skill.Attribute.m_DelayTime);
        //Task.Task emitTask = new Task.Task("释放", cc);
        //tm.AddTask(emitTask);


        //TimeCondition singCond = new TimeCondition(skill.Attribute.m_DelayTime);
        //Task.Task singTask = new Task.Task("吟唱任务", singCond);
        //tm.AddTask(singTask);

        for (int i = 0; i < skill.Attribute.m_BuffList.Count; i++)
        {
            Buff b = skill.Attribute.m_BuffList[i];
            BuffCondition bc = new BuffCondition(b, b.m_BuffTime);
            string tn = b.m_BuffName;
            Debug.Log(tn);
            Task.Task tbc = new Task.Task(tn, bc);
            tm.AddTask(tbc);

            tm.Start(">>>技能施法流程" + tn, delegate ()
            {
                b.RemoveBuff();
            });
        }

        //BuffCondition bc = new BuffCondition(skill.Attribute.m_BuffList[0],5);
        //Task.Task tbc = new Task.Task("bc任务", bc);
        //tm.AddTask(tbc);

        //tm.Start("bc任务" + attribute.Name, delegate ()
        //{
        //    skill.Attribute.m_BuffList[0].RemoveBuff();
        //});

        ////启动任务队列
        //tm.Start("吟唱任务" + attribute.Name, delegate ()
        //{
        //    Debug.Log("Hp:---------" + obj_entity.Hp);
        //    skill.End();
        //});
    }

}
