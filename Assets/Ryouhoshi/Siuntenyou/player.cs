using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //�ړ����x
    [SerializeField]
    float speed = 3;


    //�@ �A�N�e�B�u�ɂȂ����u�ԂɌĂ΂��
    void Start()
    {
       
    }

    // ���t���[���Ă΂��
    void Update()
    {
        Vector3 movement = Vector3.zero;
        float speedDelta = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            movement = new Vector3(movement.x + speedDelta, movement.y, movement.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement = new Vector3(movement.x + -speedDelta, movement.y, movement.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement = new Vector3(movement.x , movement.y, movement.z + speedDelta);
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement = new Vector3(movement.x, movement.y, movement.z + -speedDelta);
        }
       

        transform.position += movement;
    }
}
