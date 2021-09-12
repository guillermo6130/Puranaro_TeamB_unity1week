using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;  //�������̑���
    public float alfa_In;    //A�l�𑀍삷�邽�߂̕ϐ�
    float red, green, blue;    //RGB�𑀍삷�邽�߂̕ϐ�
    public bool Trigger;

    // Start is called before the first frame update
    void Start()
    {
        //Panel�̐F���擾
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;

        Trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa_In);
        if(Trigger)
            alfa_In += speed;

    }
}
