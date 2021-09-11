using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;  //�������̑���
    public float alfa_Out;    //A�l�𑀍삷�邽�߂̕ϐ�
    float red, green, blue;    //RGB�𑀍삷�邽�߂̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        //Panel�̐F���擾
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

        //�t�F�[�h�A�E�g�I�����Ƀq�G�����L�[�iCanvas���j�̈�ԏ��
        if (alfa_Out <= 0)
            transform.SetAsFirstSibling();
    }
}
