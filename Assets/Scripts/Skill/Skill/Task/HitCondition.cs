using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 伤害处理条件
/// </summary>
namespace SkillSystem
{
    public class HitCondition : TaskSystem.TimesCondition
    {
        private Skill m_Skill;
        public HitCondition(Skill skill, int times) : base(times)
        {
            this.m_Skill = skill;
        }
        public HitCondition(int times) : base(times)
        {

        }

        public override void Start()
        {
            base.Start();

            string eff_hit = m_Skill.Attribute.Effect_HitName;
            for (int i = 0; i < this.m_times; i++)
            {
                //to-do 根据名字创建特效文件，并绑定处理脚本 HitViewer
                GameObject go = ResManager.Instance().Load(m_Skill.Attribute.Effect_HitName);
                go.transform.SetParent(m_Skill.Target.trans);
                go.transform.localPosition = Vector3.zero;
                go.transform.LookAt(m_Skill.Target.trans);
                HitViewer view = go.AddComponent<HitViewer>();
                //view.Cast(recevier: Handle, time: 0.5f);
                view.Cast(Handle, 0.01f);
            }
        }
    }
}