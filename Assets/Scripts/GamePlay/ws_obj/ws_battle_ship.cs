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
        Buff b = new Buff();
        b.AtRound = 1;
        list.Add(b);

        obj_entity.AddBuff(skill);
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
        tm.Start("技能伤害计算流程"+ attribute.Name);
    }
    public override void Fire2(Skill skill)
    { 
        //to-do吟唱 吟唱时间可以根据表格来
        TimeCondition singCond = new TimeCondition(5);
        Task.Task singTask = new Task.Task("吟唱任务2", singCond);
        tm.AddTask(singTask);
        //伤害计算
        DamageCondtion dmgCond = new DamageCondtion(skill,
                                                    delegate (int result)
                                                    {
                                                        HandleCast(skill, result);
                                                    },
                                                    EventsType.Skill_EndDmg);
        Task.Task dmgTask = new Task.Task("伤害检查2" + attribute.Name, dmgCond);
        tm.AddTask(dmgTask);
        //启动任务队列
        tm.Start("技能伤害计算流程2" + attribute.Name);
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

    
}
