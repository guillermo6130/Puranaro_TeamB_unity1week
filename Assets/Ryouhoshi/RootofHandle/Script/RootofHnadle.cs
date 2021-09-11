using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RootofHnadle : MonoBehaviour
{
     AudioSource audiosource;�@//AudioSource�̕ϐ�
    [SerializeField] public AudioClip SE1; //�ԋʗp���ʉ�������Ƃ�
    [SerializeField] public AudioClip SE2; //�ʗp���ʉ�������Ƃ�

    [SerializeField] GameObject Fortunguage;
    FortuneGauge fguage;

    public GameObject luckyEffect;

    [SerializeField] float mainasufortune;


    // Start is called before the first frame update
    void Start()
    {
        fguage = Fortunguage.GetComponent<FortuneGauge>();


        //AudioSource���g����悤�ɂ���
        audiosource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
       
    }


    //�G���v�e�B�I�u�W�F�N�g�̃R���W�����ɍK�^�ʁE�s�^�ʂ��u�G�ꂽ�v���p
    private void OnCollisionEnter(Collision collision)
    {
        //�K�^�ʂɐG�ꂽ��K�^�ʂ������A����������SE���o�͂��A�X�R�A���Z�̕ϐ����Ăяo��(�I�u�W�F�N�gtag�Ŕ���)
        if (collision.gameObject.tag == "LuckyBall")
        {

            Destroy(collision.gameObject);

            audiosource.PlayOneShot(SE1);

            GameObject.Find("Score").SendMessage("Addpoint");


        }

        //�s�^�ʂ��G��Ă�����s�^�ʂ������āA����������SE���o�͂���(�I�u�W�F�N�gtag�Ŕ���)
        if (collision.gameObject.tag == "UnLuckyBall")
        {

            Destroy(collision.gameObject);

            audiosource.PlayOneShot(SE2);

            fguage.addFortuneGauge(mainasufortune);
        }
    }

}
