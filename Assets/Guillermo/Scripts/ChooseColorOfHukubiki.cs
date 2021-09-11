using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColorOfHukubiki : MonoBehaviour
{
    [SerializeField] Material[] materials;
    int gradeNum;
    int Thisgrade;
    //ScoreKeepScript scorekeeper;
    [SerializeField] float[] Numbers;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("a");
        Thisgrade = 0;
        gradeNum = materials.Length;

        setMaterialWithNumber(calculateNumber());
    }

    void setMaterialWithNumber(int i)
    {
        this.GetComponent<Renderer>().material = materials[i];
    }

    int calculateNumber()
    {
        //float score = scorekeeper.getScore();
        float score = 10;
        for(int i = 0; i < gradeNum; i++)
        {
            if (score <= Numbers[i])
            {
                return i;
            }
        }
        return gradeNum-1;
    }
}
