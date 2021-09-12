using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestirctScript : MonoBehaviour
{
    // �J�E���g�_�E��
    public float countdown = 60.0f;
    public float count = 3f;
    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;
    [SerializeField] GameObject Create;
    [SerializeField] GameObject Handle;
    bool Stop=true;


    private void Start()
    {
        Create.SetActive(false);
        Handle.SetActive(false) ;
    }

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
        if (count >= 0)
        {
            BeforeStart();
        }
        else
        {
            Stop = false;
            Create.SetActive(true);
            Handle.SetActive(true);
        }
    }

    void Call()
    {
        
        SceneManager.LoadScene("Result");
    }

    void BeforeStart()
    {
        
        count -= Time.deltaTime;
        timeText.text = count.ToString("f1");
    }

    
}       

