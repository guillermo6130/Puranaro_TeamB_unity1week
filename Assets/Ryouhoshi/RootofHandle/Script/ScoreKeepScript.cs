using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeepScript : MonoBehaviour
{

    [SerializeField] GameObject Score;
    Score Sc;
    float Scorekeep;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        Sc = Score.GetComponent<Score>();

       

    }

    // Update is called once per frame
    void Update()
    {
        if (Sc != null)
        {
            Saveallvalue();
        }
    }

   public void Saveallvalue()
    {
        Scorekeep = Sc.score;
        
    }

    public float getScore()
    {
        return Scorekeep;
    }
}
