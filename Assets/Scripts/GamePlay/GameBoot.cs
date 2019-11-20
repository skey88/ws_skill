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
        obj2.skill.Init(obj2.obj_entity, obj2.obj_entity, obj2.attribute, obj2.SkillEnd); 
    }
     

    public void OnClick()
    {
        //obj.Fire(obj.skill);
        obj.sm.Fire(obj.skill);
    }

    public void OnClick02()
    {
        obj.Fire2(obj.skill);
    }

    public void OnClick2()
    {
        obj2.Fire(obj2.skill);
    }
}
