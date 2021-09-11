using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestirctScript : MonoBehaviour
{
    // �J�E���g�_�E��
    public float countdown = 60.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;

    bool Stop=false;


    

    // Update is called once per frame
    void Update()
    {
        if (Stop == false)
        {
            //���Ԃ��J�E���g�_�E������
            countdown -= Time.deltaTime;

            //���Ԃ�\������
            timeText.text = countdown.ToString("f1");
        }
        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0 )
        {
            Stop = true;
            timeText.text = "�I���I";
            
            //3�b���Call�֐������s
            Invoke("Call", 0.5f);
        }
    }

    void Call()
    {
        
        SceneManager.LoadScene("Result");
    }
    
}       

