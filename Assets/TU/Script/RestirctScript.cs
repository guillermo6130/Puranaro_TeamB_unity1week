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

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1");

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
<<<<<<< HEAD
            //timeText.text = "�I���I";
            //3�b���Call�֐������s
            Invoke("Call", 3f);
            SceneManager.LoadScene("Retry_TitleScene");
=======
            timeText.text = "�I���I";
            Invoke("ChangeScene", 0.5f);
>>>>>>> main
        }
    }

<<<<<<< HEAD
    
}       

=======
    void ChangeScene()
    {
        SceneManager.LoadScene("Result");
    }
}
>>>>>>> main
