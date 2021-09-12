using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    public bool ResultTrigger;

    // Start is called before the first frame update
    void Start()
    {
        ResultTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultTrigger)
        {
            FadeIn.GetComponent<FadeIn>().Trigger = true;
            //FadeIn�I�u�W�F�N�g���q�G�����L�[�iCanvas)�̈�ԉ���
            FadeIn.transform.SetAsLastSibling();
        }

        //FadeIn��������ResultScene�֑J��
        if (FadeIn.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //Trigger��false�ɂ���
            //�V�[���J��
            FadeIn.GetComponent<FadeIn>().Trigger = false;
            ResultTrigger = false;
            SceneManager.LoadScene("ResultScene");
        }
    }

    //ResultScene�J�ڂ̃e�X�g�{�^���p
    public void ResultOnClick()
    {
        ResultTrigger = true;
    }
}
