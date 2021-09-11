using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    //FadePanelを格納する
    [SerializeField] GameObject FadePanel;
    //OptionWindowを格納する2
    [SerializeField] GameObject OptionWindow;

    // Start is called before the first frame update
    void Start()
    {
        //OptionWindowオブジェクトを非表示にする
        OptionWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //FadePanelオブジェクトのA値を参照。1以上になったらシーン遷移
        //FadeOut完了時にメインゲームシーンへ遷移
        if(FadePanel.GetComponent<FadeIn>().alfa_In >= 1)
        {
            //テスト用のGameSceneに遷移している。シーン名が違う場合は（）内を変更されたし
            SceneManager.LoadScene("GameScene");
        }
    }

    public void OptionClick()
    {
        OptionWindow.SetActive(true);
    }
}
