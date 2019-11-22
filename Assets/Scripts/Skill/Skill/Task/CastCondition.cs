using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Task;
namespace SkillSystem
{
    public class CastCondition : TimeCondition
    { 
        private Skill m_Skill;
        public CastCondition(Skill skill, float duration) : base(duration)
        {
            this.m_Skill = skill; 
            Debug.Log("CastCondition1------------------------");
        }

        public override void Start()
        {
            base.Start();
            Debug.Log("CastCondition2------------------------");
            //TO-DO 创建特效
            GameObject go = ResManager.Instance().Load(m_Skill.Attribute.Effect_EmitName);
            //go.transform.SetParent(m_Skill.Target.trans);
            go.transform.position = m_Skill.Target.trans.position;
            //go.transform.LookAt(m_Skill.Target.trans);
            //go.transform.Translate(m_Skill.Target.trans.position);
             
            //go.transform.Translate(Vector3.forward, Space.World);


            //go.transform.localScale = Vector3.one;

        }
    }
}