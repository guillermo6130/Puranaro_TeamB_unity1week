using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RootofHnadle : MonoBehaviour
{
     AudioSource audiosource;　//AudioSourceの変数
    [SerializeField] public AudioClip SE1; //赤玉用効果音を入れるとこ
    [SerializeField] public AudioClip SE2; //青玉用効果音を入れるとこ

    [SerializeField] GameObject Fortunguage;
    FortuneGauge fguage;

    //public GameObject luckyEffect;

    [SerializeField] float mainasufortune;


    // Start is called before the first frame update
    void Start()
    {
        fguage = Fortunguage.GetComponent<FortuneGauge>();


        //AudioSourceを使えるようにする
        audiosource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
       
    }


    //エンプティオブジェクトのコリジョンに幸運玉・不運玉が「触れた」時用
    private void OnCollisionEnter(Collision collision)
    {
        //幸運玉に触れたら幸運玉を消し、いい感じのSEを出力し、スコア加算の変数を呼び出す(オブジェクトtagで判定)
        if (collision.gameObject.tag == "Lucky")
        {

            Destroy(collision.gameObject);

            audiosource.PlayOneShot(SE1);

            GameObject.Find("Score").SendMessage("Addpoint");


        }

        //不運玉が触れてきたら不運玉を消して、いい感じのSEを出力する(オブジェクトtagで判定)
        else if (collision.gameObject.tag == "Unlucky")
        {

            Destroy(collision.gameObject);

            audiosource.PlayOneShot(SE2);

            fguage.addFortuneGauge(mainasufortune);
        }
    }

}
