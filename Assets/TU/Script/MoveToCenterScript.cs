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
        //�����̈ʒu�A�^�[�Q�b�g�A���x
        transform.position = Vector3.MoveTowards(transform.position, Cube.transform.position, speed);
        
    }
}
