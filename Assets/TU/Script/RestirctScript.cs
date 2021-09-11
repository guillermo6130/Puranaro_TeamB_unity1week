using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestirctScript : MonoBehaviour
{
    // カウントダウン
    public float countdown = 60.0f;

    //時間を表示するText型の変数
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1");

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
<<<<<<< HEAD

=======
>>>>>>> parent of e472715 (9/11)
            //timeText.text = "終了！";
            //3秒後にCall関数を実行
            Invoke("Call", 3f);
            SceneManager.LoadScene("Retry_TitleScene");
<<<<<<< HEAD
            timeText.text = "終了！";
            Invoke("ChangeScene", 0.5f);

        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("Result");
    }


=======
        }
    }

    
>>>>>>> parent of e472715 (9/11)
}       

