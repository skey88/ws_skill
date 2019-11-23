using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    Vector3 fwd;

    float nowLifeTime = 0;
    float LifeTime = 0;
    float speed = 2;
    void Start()
    {
        fwd = transform.InverseTransformDirection(Vector3.forward);
        //transform.Translate(fwd);
    }
     
    void Update()
    {
        //GetComponent<Rigidbody>().AddForce(fwd * 10);//给物体一个向前的力
        //transform.Translate(fwd);
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
        nowLifeTime += Time.fixedDeltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject); 
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
