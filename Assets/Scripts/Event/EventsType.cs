using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EventsType  {
    Skill_Disperse, //技能驱散
    Skill_AddBuff, //添加Buff
    Skill_EndDmg, //伤害计算完毕
}


public enum SkillType
{
    /// <summary>
    /// 被动技能
    /// </summary>
    Passive,
    /// <summary>
    /// 主动技能
    /// </summary>
    Initiative,
    Birth,
    Child,
    //NormalAttack,
}
public enum SkillTargetType
{
    Inheritance=0, //继承
    Enemy,
    Oneself,
    Friendly, 
}
public enum SkillShipType
{
    Inheritance = 0, //继承
    A,
    B,
    C,
    D,
}

public enum SkillEffectType
{
    /// <summary>
    /// 瞬间效果
    /// </summary>
    Now,
    /// <summary>
    /// 持续效果
    /// </summary>
    Continuous,
    /// <summary>
    /// AOE
    /// </summary>
    AOE,
    /// <summary>
    /// 召唤效果
    /// </summary>
    Summon, 
}

public enum SkillAttackType
{
    Lock = 0, //锁定
    PointTowards, //指向型
}