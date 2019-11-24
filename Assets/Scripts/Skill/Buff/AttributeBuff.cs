using UnityEngine;
using System.Collections.Generic;
using SkillSystem;

public class AttributeBuff : Buff
{       
    public int m_Hp;
    public int m_Mp;
    /// <summary>
    /// 攻击力
    /// </summary>
    public int m_Fight;
    /// <summary>
    /// 防御
    /// </summary>
    public int m_Defence;
    /// <summary>
    /// 暴击
    /// </summary>
    public int m_Crit;


    public override void AddBuff()
    {
        base.AddBuff();
        for (int i = 0; i < m_TargetList.Count; i++)
        {
            m_TargetList[i].Fight += m_Value;
        }

        //m_TargetList[i].Fight += m_Value;
        Debug.Log("2.*****************Fight:" + m_TargetList[0].Fight);
    }

    public override void RemoveBuff()
    {
        base.RemoveBuff();
        for (int i = 0; i < m_TargetList.Count; i++)
        {
            m_TargetList[i].Fight -= m_Value;
        }
    }


}
