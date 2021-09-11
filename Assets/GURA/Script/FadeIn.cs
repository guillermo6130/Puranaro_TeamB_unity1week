using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;  //透明化の速さ
    public float alfa_In;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    public bool Trigger;

    // Start is called before the first frame update
    void Start()
    {
        //Panelの色を取得
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
