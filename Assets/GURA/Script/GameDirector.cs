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
            //FadeInオブジェクトをヒエラルキー（Canvas)の一番下に
            FadeIn.transform.SetAsLastSibling();
        }

        //FadeIn完了時にResultSceneへ遷移
        if (FadeIn.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //Triggerをfalseにする
            //シーン遷移
            FadeIn.GetComponent<FadeIn>().Trigger = false;
            ResultTrigger = false;
            SceneManager.LoadScene("ResultScene");
        }
    }

    //ResultScene遷移のテストボタン用
    public void ResultOnClick()
    {
        ResultTrigger = true;
    }
}
