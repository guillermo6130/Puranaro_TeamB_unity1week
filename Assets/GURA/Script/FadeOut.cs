using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;  //透明化の速さ
    public float alfa_Out;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数

    // Start is called before the first frame update
    void Start()
    {
        //Panelの色を取得
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;

        alfa_Out = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa_Out);
        alfa_Out -= speed;

        //フェードアウト終了時にヒエラルキー（Canvas内）の一番上へ
        if (alfa_Out <= 0)
            transform.SetAsFirstSibling();
    }
}
