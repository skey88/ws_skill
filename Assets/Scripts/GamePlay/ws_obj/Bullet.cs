using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    Vector3 fwd;
     
    void Start()
    {
        fwd = transform.InverseTransformDirection(Vector3.forward);
        transform.Translate(fwd);
    }
     
    void Update()
    {
        //GetComponent<Rigidbody>().AddForce(fwd * 10);//给物体一个向前的力
        transform.Translate(fwd);
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
