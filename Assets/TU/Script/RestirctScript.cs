using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestirctScript : MonoBehaviour
{
    // カウントダウン
    public float countdown = 10.0f;


    //時間を表示するText型の変数
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") ;

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            
            SceneManager.LoadScene("Retry_TitleScene");
        }

    }
}
