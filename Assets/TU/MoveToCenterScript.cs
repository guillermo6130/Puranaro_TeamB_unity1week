using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCenterScript : MonoBehaviour
{
    GameObject Cube;
    [SerializeField] float speed;

    private void Start()
    {
        Cube = GameObject.Find("RootofHnadle kansei  1");
    }
    // Update is called once per frame
    void Update()
    {
        //自分の位置、ターゲット、速度
        transform.position = Vector3.MoveTowards(transform.position, Cube.transform.position, speed);
    }
    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("hit");
        if (collider.tag == "HandleHitBox")
        {
            Invoke("DestroyThis", 0.5f);
        }

        
    }
    void DestroyThis()
    {
        
        Destroy(gameObject);
    }
}
