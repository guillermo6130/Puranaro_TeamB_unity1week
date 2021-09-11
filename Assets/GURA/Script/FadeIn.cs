using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;  //“§–¾‰»‚Ì‘¬‚³
    public float alfa_In;    //A’l‚ğ‘€ì‚·‚é‚½‚ß‚Ì•Ï”
    float red, green, blue;    //RGB‚ğ‘€ì‚·‚é‚½‚ß‚Ì•Ï”
    public bool Trigger;

    // Start is called before the first frame update
    void Start()
    {
        //Panel‚ÌF‚ğæ“¾
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
