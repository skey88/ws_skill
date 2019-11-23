using UnityEngine;
using System.Collections;
using TaskSystem;

namespace SkillSystem
{


    public class BuffCondition : TimeCondition
    {

        private Buff m_Buff;
         
        public BuffCondition(Buff buff, float duration) : base(duration)
        {
            this.m_Buff = buff;
        }




        public override void Start()
        {
            base.Start();
            m_Buff.AddBuff(); 
        }
    }
}