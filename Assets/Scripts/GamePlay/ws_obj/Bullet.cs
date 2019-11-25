using UnityEngine;
using System.Collections;
using SkillSystem;
using TaskSystem;

public class Bullet : MonoBehaviour {

    Vector3 fwd;

    private float nowLifeTime = 0;
    private float LifeTime = 0;
    private float speed = 1;
    private CollisionDetector cd = null;


    private bool isTrigger = false;
    private Skill m_Skill = null;
    void Start()
    {
        fwd = transform.InverseTransformDirection(Vector3.forward);
        cd = GetComponent<CollisionDetector>(); 
    }

    public void InitBullet(SkillSystem.Skill skill)
    {
        m_Skill = skill;

    }



     
    void Update()
    {
        //GetComponent<Rigidbody>().AddForce(fwd * 10);//给物体一个向前的力
        //transform.Translate(fwd);
    }

    private void FixedUpdate()
    {
        if (!cd.IsCollidingVertically())
        {
            transform.position += transform.forward * speed * Time.fixedDeltaTime;
            nowLifeTime += Time.fixedDeltaTime;
        }
        else
        {
            if (!isTrigger)
            {
                OnCollision();
                isTrigger = true;
            }
        }
    }

    private void OnCollision()
    {
        //Destroy(gameObject);
        WsTaskManager tm = new TaskSystem.WsTaskManager();
        //打击效果
        Task hitTask = new Task("击中效果", new HitCondition(m_Skill, 1));
        tm.AddTask(hitTask);
        DamageCondtion dmgCond = new DamageCondtion(m_Skill,
                                                                    delegate (int result)
                                                                    {
                                                                        HandleCast(m_Skill, result);
                                                                    },
                                                                    EventsType.Skill_DamageEnd, m_Skill.Caster.m_Id);
        Task dmgTask = new Task("伤害检查", dmgCond);
        tm.AddTask(dmgTask); 
        //启动任务队列
        tm.Start(">>>技能施法流程", delegate ()
        {
            m_Skill.End();
        });
    }
    public void HandleCast(Skill skill, int result)
    {
        Debug.Log("伤害计算");
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
