using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SkillSystem
{

    public enum WsBuffState
    {
        S1,
        S2,

    }



    public class Buff
    {


        /// <summary>
        /// Buff
        /// </summary>
        public string m_BuffName;
        /// <summary>
        /// Buff影响多长时间
        /// </summary>
        public float m_BuffTime;
        /// <summary>
        /// Buff延迟多长时间开始生效
        /// </summary>
        public float m_DelayTime;


        public virtual void AddBuff()
        {
            Debug.Log("AddBuff---------------------------"+ m_BuffName);
        }


        public virtual void RemoveBuff()
        {
            Debug.Log("RemoveBuff------------------------" + m_BuffName);
        }















        private int m_AtRound;
        private Skill m_Skill;

        public int AtRound
        {
            get
            {
                return m_AtRound;
            }

            set
            {
                m_AtRound = value;
            }
        }

        public Skill Skill
        {
            get
            {
                return m_Skill;
            }

            set
            {
                m_Skill = value;
            }
        }
    }
}
