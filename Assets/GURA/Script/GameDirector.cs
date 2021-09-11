using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //FadeIn��������ResultScene�֑J��
        if (FadeIn.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //Trigger��false�ɂ���
            //�V�[���J��
            FadeIn.GetComponent<FadeIn>().Trigger = false;
            SceneManager.LoadScene("ResultScene");
        }
    }

    //ResultScene�J�ڂ̃e�X�g�{�^���p
    public void ResultOnClick()
    {
        FadeIn.GetComponent<FadeIn>().Trigger = true;
        //FadeIn�I�u�W�F�N�g���q�G�����L�[�iCanvas)�̈�ԉ���
        FadeIn.transform.SetAsLastSibling();
    }

}
