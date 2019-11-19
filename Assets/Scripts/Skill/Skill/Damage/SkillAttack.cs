using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Skill
{

    public class SkillAttack : IDamage
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
                    if (target.Hp < 0) target.Hp = 0;
                }
            }
            return value;
        }
    }
}