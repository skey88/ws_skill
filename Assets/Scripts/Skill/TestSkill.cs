using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillSystem;
public class TestSkill : MonoBehaviour {

	IEnumerator Start () {
        Attribute attribute = new Attribute();
        attribute.CostMp = 5;
        attribute.m_DelayTime = 2;

        SkillSystem.Skill windy = new SkillSystem.Skill();
        Entity sakura = new Entity();
        sakura.Name = "小樱";
        sakura.Mp = 10;
        Entity enemy = new Entity();

       
        windy.Init(sakura, enemy, attribute);
   //检验流程
        bool isvalid = windy.IsValid(new MpVerify());
        if (!isvalid)
        {
            windy.Interrupt(new InterruptValid());
        }


        Debug.Log("准备 吟唱");
        TaskSystem.TimeCondition cond = new TaskSystem.TimeCondition(attribute.m_DelayTime);
        TaskSystem.Task task = new TaskSystem.Task("吟唱动画", cond);

        yield return StartCoroutine(windy.Sing(task));

        Debug.Log("吟唱 结束");
	}
	
	void Update () {
		
	}
}
