using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    //FadePanel���i�[����
    [SerializeField] GameObject FadePanel;
    //OptionWindow���i�[����2
    [SerializeField] GameObject OptionWindow;

    // Start is called before the first frame update
    void Start()
    {
        //OptionWindow�I�u�W�F�N�g���\���ɂ���
        OptionWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //FadePanel�I�u�W�F�N�g��A�l���Q�ƁB1�ȏ�ɂȂ�����V�[���J��
        //FadeOut�������Ƀ��C���Q�[���V�[���֑J��
        if(FadePanel.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //�e�X�g�p��GameScene�ɑJ�ڂ��Ă���B�V�[�������Ⴄ�ꍇ�́i�j����ύX���ꂽ��
            SceneManager.LoadScene("GameScene");
        }
    }

    public void OptionClick()
    {
        OptionWindow.SetActive(true);
    }
}
