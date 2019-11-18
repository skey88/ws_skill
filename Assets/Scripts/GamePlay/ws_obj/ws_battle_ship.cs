using UnityEngine;
using System.Collections;

public class ws_battle_ship : ws_fight_obj
{


    protected override void Awake()
    {
        base.Awake();
        obj_entity.Fight = 10;
        obj_entity.Defence = 10; 
    } 

}
