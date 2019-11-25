using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TaskSystem; 
namespace SkillSystem
{
    public delegate void TrigSkill(Skill skill);

    public class SkillManager 
    {
        /// <summary>
        /// 需要根据需要初始化技能数据
        /// </summary>
        private Dictionary<int, SkillTable> m_Skills;
        /// <summary>
        /// 任务管理器
        /// </summary>
        private WsTaskManager m_tm;


        public  SkillManager(WsTaskManager tm)
        {
            m_tm = tm;
        }

        public void InitSkillList()
        {


        } 
        /// <summary>
        /// 技能的合法性验证， 通过TrigSkill返回触发的技能
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="caster">施法者</param>
        /// <param name="target">目标</param>
        /// <param name="trig">技能触发</param>
        /// <param name="complate">技能完成回掉</param>
        public void Verify(int skillId, Entity caster, Entity target, TrigSkill trig, SkillComplate complate)
        {
            //查阅技能
            if (!m_Skills.ContainsKey(skillId))
            {
                throw new KeyNotFoundException(string.Format("{0} 不在技能表"));
            }
            SkillTable skilldata = m_Skills[skillId];
            //根据技能表组装技能属性
            Attribute attribue = new Attribute();
            attribue.CostMp = skilldata.Cost;

            //使用技能属性初始化技能[这里后续使用对象池获取对象，暂时直接new]
            Skill skill = new Skill();
            skill.Init(caster, target, attribue, complate);

            //检查释放条件
            //蓝耗检查
            if (skilldata.Cost > 0)
            {
                if (!skill.IsValid(new MpVerify()))
                {
                    trig(null);
                    return;
                }
            }
            //to-do其他检查
            trig(skill);
        }

        /// <summary>
        /// 1.放技能
        /// </summary>
        /// <param name="skill"></param>
        public void Fire(Skill skill)
        {
            //to-do吟唱 吟唱时间可以根据表格来
            TimeCondition singCond = new TimeCondition(skill.Attribute.m_DelayTime);//
            Task singTask = new Task("吟唱任务", singCond);
            m_tm.AddTask(singTask);

            Task emitTask = new Task("释放", new CastCondition(skill, 0.1f));
            m_tm.AddTask(emitTask);
            //启动任务队列
            m_tm.Start("吟唱任务");
        }



        /// <summary>
        /// 2.处理施法
        /// </summary>
        /// <param name="skill"></param>
        /// <param name="result"></param>
        public void HandleCast(Skill skill, int result)
        { 
            //释放特效
            Task emitTask = new Task("释放", new CastCondition(skill, 0.1f));
            m_tm.AddTask(emitTask);  
            //启动任务队列
            m_tm.Start(">>>技能施法流程", delegate ()
            {
                skill.End();
            });
        }

        /// <summary>
        /// 3.击中爆炸，计算伤害
        /// </summary>
        /// <param name="skill"></param>
        public void Hit(Skill skill)
        {
            DamageCondtion dmgCond = new DamageCondtion(skill,
                                                                    delegate (int result)
                                                                    {
                                                                        HandleCast(skill, result);
                                                                    },
                                                                    EventsType.Skill_DamageEnd, skill.Caster.m_Id);
            Task dmgTask = new Task("伤害检查", dmgCond);
            m_tm.AddTask(dmgTask);
            //启动任务队列
            m_tm.Start("吟唱任务"); 
        }


        public void Fire03(Skill skill)
        {
            //伤害计算
            DamageCondtion dmgCond = new DamageCondtion(skill,
                                                        delegate (int result)
                                                        {
                                                            HandleCast(skill, result);
                                                        },
                                                        EventsType.Skill_DamageEnd, skill.Caster.m_Id);
            TaskSystem.Task dmgTask = new TaskSystem.Task("伤害检查" + skill.Attribute.Name, dmgCond);
            m_tm.AddTask(dmgTask);
            //启动任务队列
            m_tm.Start("技能伤害计算流程" + skill.Attribute.Name);
        }


        public void Fire02(Skill skill)
        {
            string que01 = "蓄力队列>01";
            TimeCondition singCond = new TimeCondition(skill.Attribute.m_DelayTime);
            TaskSystem.Task singTask = new TaskSystem.Task("    蓄力任务", singCond);
            m_tm.AddTask(singTask);
            m_tm.Start(que01, delegate ()
            {
                Debug.Log(que01 + "队列结束********************************************");
                for (int i = 0; i < skill.Attribute.m_BuffList.Count; i++)
                {
                    WsTaskManager wtm = new WsTaskManager();
                    Buff b = skill.Attribute.m_BuffList[i];

                    TimeCondition singCond3 = new TimeCondition(b.m_DelayTime);
                    TaskSystem.Task singTask3 = new TaskSystem.Task("A           buff延迟任务" + (i + 1), singCond3);
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

        }

    }
}
