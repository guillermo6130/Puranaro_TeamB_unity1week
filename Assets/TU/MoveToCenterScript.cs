using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCenterScript : MonoBehaviour
{
    public GameObject Cube;
    [SerializeField] float speed;


    // Update is called once per frame
    void Update()
    {
        //自分の位置、ターゲット、速度
        transform.position = Vector3.MoveTowards(transform.position, Cube.transform.position, speed);
        
    }
}
