using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uzukaitenScript : MonoBehaviour
{
    public float speed = 10f; //��]���鑬�x��ݒ肵�܂��B�}�C�i�X�l�ɂ���ƁA�t��]�ɂȂ�܂��B

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);�@//�ݒ肵�������ŁAY���ɉ�]���܂�
    }
}
