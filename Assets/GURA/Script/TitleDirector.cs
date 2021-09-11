using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    //FadePanel���i�[����
    [SerializeField] GameObject FadeIn;
    //OptionWindow���i�[����2
    [SerializeField] GameObject OptionWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FadePanel�I�u�W�F�N�g��A�l���Q�ƁB1�ȏ�ɂȂ�����V�[���J��
        //FadeOut�������Ƀ��C���Q�[���V�[���֑J��
        if (FadeIn.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //����true��Trigger��false�ɂ���
            //�e�X�g�p��GameScene�ɑJ�ڂ��Ă���B�V�[�������Ⴄ�ꍇ�́i�j����ύX���ꂽ��
            FadeIn.GetComponent<FadeIn>().Trigger = false;
            SceneManager.LoadScene("Main");
        }
    }

    public void OptionClick()
    {
        OptionWindow.SetActive(true);
    }

    public void OptionCancel()
    {
        OptionWindow.SetActive(false);
    }

    public void StartClick()
    {
        FadeIn.GetComponent<FadeIn>().Trigger = true;
        FadeIn.transform.SetAsLastSibling();

    }
}
