using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 普通攻击
/// </summary>
namespace SkillSystem
{
    public class NormalAttack : IDamage
    {
        /// <summary>
        /// 对象
        /// </summary>
        private List<Entity> m_Target;

        public List<Entity> Target
        {
            get
            {
                return m_Target;
            }

            set
            {
                m_Target = value;
            }
        }

        public int Handle(Skill skill)
        {
            int value = skill.Attribute.Value;
            if (m_Target != null)
            {
                foreach (var target in m_Target)
                {
                    target.Hp -= value;
                    if (target.Hp<0) target.Hp = 0; 
                }
            }
            return value;
        }
    }
}