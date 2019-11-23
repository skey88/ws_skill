using UnityEngine;
using System.Collections;
using SkillSystem;
using System.Collections.Generic;
using TaskSystem;

public class ws_attackAble_obj : MonoBehaviour {

    public ulong obj_Id;
    public WsTaskManager tm;
    public SkillManager sm;
    public Attribute attribute;

    public Skill skill; 
    public  Entity obj_entity;

    protected virtual void Awake()
    {
        tm = new WsTaskManager();
        sm = new SkillManager(tm);
        obj_entity = new Entity();
        obj_entity.m_Id = 100000001;
        obj_entity.Hp = 100;
        obj_entity.Mp = 100;
        obj_entity.MaxHp = 100;
        obj_entity.MaxMp = 100;
        obj_entity.Fight = 10;
        obj_entity.Defence = 10;
        obj_entity.trans = gameObject.transform; 
        attribute.m_BuffList = new List<Buff>();
        List<Buff> list = new List<Buff>();
        Buff b = new Buff();
        b.AtRound = 1;
        list.Add(b); 
    }

    public virtual void Fire(Skill skill)
    {

    }

    public virtual void Fire2(Skill skill)
    {

    }
    public void SkillEnd(Skill sk)
    {
        Debug.Log("SkillEnd");
    }
}
