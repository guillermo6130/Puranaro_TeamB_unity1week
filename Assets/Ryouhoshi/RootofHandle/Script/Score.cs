using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText; //��ʂɕ\�����镶����public�ϐ��Ƃ���
    public  int score ; //���Ԃ�X�R�A�\���p�̕ϐ�

    
    // �ϐ������������A�X�R�A��\������
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;

    }

   

    // Update is called once per frame
    void Update()
    {
       
    }

    //�X�R�A��10���Z���A�V�����X�R�A��\������
    public void Addpoint()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
