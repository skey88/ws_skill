using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Task;
using SkillTask = Task.Task;
using Skill;

public class ResManager : ISingleton<ResManager>
{

     public GameObject Load(string name)
    {
        GameObject go = GameObject.Instantiate(Resources.Load(name) as GameObject); 
        return go;
    }
 
}
