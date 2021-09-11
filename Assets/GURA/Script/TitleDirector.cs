using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    //FadePanelを格納する
    [SerializeField] GameObject FadeIn;
    //OptionWindowを格納する2
    [SerializeField] GameObject OptionWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FadePanelオブジェクトのA値を参照。1以上になったらシーン遷移
        //FadeOut完了時にメインゲームシーンへ遷移
        if (FadeIn.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //条件trueでTriggerをfalseにする
            //テスト用のGameSceneに遷移している。シーン名が違う場合は（）内を変更されたし
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
