using UnityEngine;
using System.Collections;

public class GameBoot : MonoBehaviour {

    public ws_attackAble_obj obj;
    public ws_attackAble_obj obj2;
     

    private void Awake()
    {
        
    }
    private void Start()
    {
        Init();
    }

    public void Init()
    {
        obj.skill.Init(obj.obj_entity, obj2.obj_entity, obj.attribute, obj.SkillEnd);
        obj2.skill.Init(obj2.obj_entity, obj.obj_entity, obj2.attribute, obj2.SkillEnd); 
    }
     

    public void Skill0101()
    {
        //obj.Fire(obj.skill);
        obj.sm.Fire(obj.skill);
    }

    public void Skill0102()
    {
        obj.sm.Fire02(obj.skill);
    }

    public void Skill0201()
    {
        obj2.sm.Fire(obj2.skill);
    }
    public void Skill0202()
    {
        obj2.sm.Fire02(obj2.skill);
    }
}
