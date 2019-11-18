using UnityEngine;
using System.Collections;
using Skill;
using System.Collections.Generic;

public class ws_attackAble_obj : MonoBehaviour {

   public  Entity obj_entity;

    protected virtual void Awake()
    {
        obj_entity = new Entity();
        obj_entity.Hp = 100;
        obj_entity.Mp = 100;
        obj_entity.MaxHp = 100;
        obj_entity.MaxMp = 100;
        obj_entity.Fight = 10;
        obj_entity.Defence = 10;
        List<Buff> list = new List<Buff>();
        Buff b = new Buff();
        b.AtRound = 1;
        list.Add(b); 
    }
}
