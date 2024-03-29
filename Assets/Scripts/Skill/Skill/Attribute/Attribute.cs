﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SkillSystem
{
    [System.Serializable]
    public partial class Attribute
    {

        public float m_DelayTime;
        public List<Buff> m_BuffList;

        public int m_Id;
        public int m_Name;
        public int m_CostMp;
        public int m_CD;
        /// <summary>
        /// BUFF 作用的回合数
        /// </summary>
        public int m_BuffAffectRound;
        /// <summary>
        /// Buff在第几回合开始作用
        /// </summary>
        public int m_BuffAtRound;
        /// <summary>
        /// 作用值
        /// </summary>
        public int m_Value;
        /// <summary>
        /// 互斥的技能列表, 用于技能驱散
        /// </summary>
        public List<int> m_Mute;
        /// <summary>
        /// 伤害造成的段数
        /// </summary>
        public int m_Segment;


        public int Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public int CostMp
        {
            get
            {
                return m_CostMp;
            }

            set
            {
                m_CostMp = value;
            }
        }

        public int CD
        {
            get
            {
                return m_CD;
            }

            set
            {
                m_CD = value;
            }
        }

        public int AffectRound
        {
            get
            {
                return m_BuffAffectRound;
            }

            set
            {
                m_BuffAffectRound = value;
            }
        }



        public int Value
        {
            get
            {
                return m_Value;
            }

            set
            {
                m_Value = value;
            }
        }

        public int AtRound
        {
            get
            {
                return m_BuffAtRound;
            }

            set
            {
                m_BuffAtRound = value;
            }
        }

        public List<int> Mute
        {
            get
            {
                return m_Mute;
            }

            set
            {
                m_Mute = value;
            }
        }

        public int Segment
        {
            get
            {
                return m_Segment;
            }

            set
            {
                m_Segment = value;
            }
        }

        public int Id
        {
            get
            {
                return m_Id;
            }

            set
            {
                m_Id = value;
            }
        }
    }
}
