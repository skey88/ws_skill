using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TaskSystem;
namespace SkillSystem
{
    public delegate void DamageResult(int result);
    public class DamageCondtion : EventCondition
    {
        private ulong m_Id;
        private Skill m_Skill;
        private DamageResult m_Result;
        public DamageCondtion(Skill skill, DamageResult result, EventsType type,ulong Id) : base(type)
        {
            this.m_Skill = skill;
            this.m_Result = result;
        }

        public DamageCondtion(EventsType type) : base(type)
        {

        }

        public override void Start()
        {
            base.Start();
            //to-do 这里需要根据技能类型创建不同类型的伤害计算，这里简单的已处理加固定血量来模拟计算
            SkillAttack sa = new SkillAttack();
            sa.Target = new List<Entity>(); 
            sa.Target.Add(m_Skill.Target);
            int result = this.m_Skill.Caculate(sa);

            //int result = this.m_Skill.Caculate(new FixAddHp());
            if (m_Result != null)
                m_Result(result);
            //注意: 伤害计算结束后需要触发伤害计算结束的事件,来终止任务的执行
            //EventsMgr.GetInstance().TriigerEvent(EventsType.Skill_EndDmg, null);

            GlobalEventsMgr.GetInstance().SendEvent(m_Id, EventsType.Skill_DamageEnd, result);
        }
    }
}
