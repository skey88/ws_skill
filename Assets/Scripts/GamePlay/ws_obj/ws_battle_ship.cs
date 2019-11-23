using UnityEngine;
using System.Collections;
using TaskSystem;
using System.Collections.Generic;
using SkillSystem;

public class ws_battle_ship : ws_fight_obj
{
    protected override void Awake()
    {
        base.Awake();
        obj_entity.m_Id = 10000000+obj_entity.m_Id;
        obj_entity.Fight = 10;
        obj_entity.Defence = 10;
        obj_entity.Name = "战舰"+ attribute.Name;

        skill = new Skill();
        skill.Attribute = attribute;
        List<Buff> list = new List<Buff>();
        AttributeBuff b = new AttributeBuff();
        b.m_BuffName = "buff001";
        b.m_DelayTime = 5;
        b.m_BuffTime = 5;
        b.m_Fight = 50;
        list.Add(b);
        AttributeBuff b2 = new AttributeBuff();
        b2.m_BuffName = "buff002";
        b.m_DelayTime = 30;
        b2.m_BuffTime = 5;
        b2.m_Fight = 20;
        list.Add(b2);
        skill.Attribute.m_BuffList.AddRange(list);
        obj_entity.AddBuff(b);
        obj_entity.AddBuff(b2);
        sm.InitSkillList();
        Debug.Log("1.初始Hp:" + obj_entity.Hp);
        GlobalEventsMgr.GetInstance().RegEvent(obj_Id, EventsType.Skill_DamageEnd, HpValue);
    }





    public override void Fire(Skill skill)
    {
        TimeCondition singCond = new TimeCondition(skill.Attribute.m_DelayTime);
        TaskSystem.Task singTask = new TaskSystem.Task("吟唱任务", singCond);
        tm.AddTask(singTask);

        //伤害计算
        DamageCondtion dmgCond = new DamageCondtion(skill,
                                                    delegate (int result)
                                                    {
                                                        HandleCast(skill, result);
                                                    },
                                                    EventsType.Skill_DamageEnd,
                                                    obj_Id);
        TaskSystem.Task dmgTask = new TaskSystem.Task("伤害检查"+ attribute.Name, dmgCond);
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
        TaskSystem.Task emitTask = new TaskSystem.Task("释放", new CastCondition(skill, 0.5f));
        tm.AddTask(emitTask);

        //打击效果
        TaskSystem.Task hitTask = new TaskSystem.Task("打击效果", new HitCondition(skill, 1));
        tm.AddTask(hitTask);

        ////启动任务队列
        tm.Start(">>>技能施法流程" + attribute.Name, delegate ()
        {
            //Debug.Log("Hp:" + obj_entity.Hp);
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

        //WsTaskManager tm1 = new WsTaskManager();
        //Buff b = skill.Attribute.m_BuffList[0];
        //BuffCondition bc = new BuffCondition(b, b.m_BuffTime);
        //string tn = b.m_BuffName;
        ////Debug.Log(tn);
        //Task.Task tbc = new Task.Task(tn, bc);
        //tm1.AddTask(tbc);

        //tm1.Start(tn, delegate ()
        //{
        //    b.RemoveBuff();
        //});


        //Buff b2 = skill.Attribute.m_BuffList[1];
        //BuffCondition bc2 = new BuffCondition(b2, b2.m_BuffTime);
        //string tn2 = b2.m_BuffName;
        //Debug.Log(tn2);
        //Task.Task tbc2 = new Task.Task(tn2, bc);
        //tm.AddTask(tbc2);

        //tm.Start(tn2, delegate ()
        //{
        //    b2.RemoveBuff();
        //});

        string que01 = "蓄力队列>01";
        TimeCondition singCond = new TimeCondition(skill.Attribute.m_DelayTime);
        TaskSystem.Task singTask = new TaskSystem.Task("    蓄力任务", singCond);
        tm.AddTask(singTask);
        tm.Start(que01, delegate ()
        {
            Debug.Log(que01+"队列结束********************************************");
            for (int i = 0; i < skill.Attribute.m_BuffList.Count; i++)
            {
                WsTaskManager wtm = new WsTaskManager();
                Buff b = skill.Attribute.m_BuffList[i];

                TimeCondition singCond3 = new TimeCondition(b.m_DelayTime);
                TaskSystem.Task singTask3 = new TaskSystem.Task("A           buff延迟任务"+(i+1), singCond3);
                wtm.AddTask(singTask3);   
                wtm.Start("           buff延迟队列>" + (i + 1), delegate ()
                {
                    //Debug.Log("           buff延迟队列结束>" + (i + 1));   
                    Debug.Log("buff延迟任务队列结束********************************************");
                    WsTaskManager wtm2 = new WsTaskManager();
                    string tn = "B                      buff生效任务：" + b.m_BuffName;
                    BuffCondition bc = new BuffCondition(b, b.m_BuffTime);
                    //Debug.Log(tn);
                    TaskSystem.Task tbc = new TaskSystem.Task(tn, bc);
                    wtm2.AddTask(tbc);

                    wtm2.Start("000           buff队列>" + (i + 1), delegate ()
                    {
                        Debug.Log("buff队列队列结束********************************************");
                        b.RemoveBuff();
                    });     
                });

            }
        });


        //TimeCondition singCond2 = new TimeCondition(skill.Attribute.m_DelayTime);
        //Task.Task singTask2 = new Task.Task("吟唱任务2", singCond2);
        //tm.AddTask(singTask2);
        //tm.Start("队列02", delegate ()
        //{
        //    Debug.Log("队列02结束------------------------------------------");
        //});
        

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


    public void HpValue(object obj)
    {
        int hp = System.Convert.ToInt32(obj);
        obj_entity.Hp -= hp;
        Debug.Log("2.技能结束Hp:" + obj_entity.Hp);
    }
}
