using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText; //画面に表示する文字をpublic変数とする
    public  int score ; //たぶんスコア表示用の変数

    
    // 変数を初期化し、スコアを表示する
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;

    }

   

    // Update is called once per frame
    void Update()
    {
       
    }

    //スコアを10加算し、新しいスコアを表示する
    public void Addpoint()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
