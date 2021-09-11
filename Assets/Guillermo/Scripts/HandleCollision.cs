using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollision : MonoBehaviour
{
    [SerializeField] float impulseMagnitude;
    MoveToCenterScript ball;
    // Start is called before the first frame update
    void Start()
    {
        impulseMagnitude = 50.0f;
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("hit");
        Rigidbody rigid = collider.gameObject.GetComponent<Rigidbody>();
        

        Vector3 impulse = (rigid.position - transform.parent.position).normalized * this.impulseMagnitude;
        

        rigid.AddForce(impulse, ForceMode.Impulse);

        
    }
}
