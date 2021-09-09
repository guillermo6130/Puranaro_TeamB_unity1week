using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortuneGauge : MonoBehaviour
{
    [SerializeField] GameObject Handle;
    HandleController HandleController;

    float FortuneValue=0;
    float preRotateNum=0;

    [SerializeField]float maxFortuneValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        HandleController = Handle.GetComponent<HandleController>();
    }

    // Update is called once per frame
    void Update()
    {
        FortuneIncByRotateNum();
        Debug.Log(FortuneValue);
    }

    public void FortuneIncByRotateNum()
    {
        float IncRotateNum = 0;
        IncRotateNum = HandleController.getRotateNum();
        FortuneValue += IncRotateNum-preRotateNum;
        preRotateNum = HandleController.getRotateNum();
        //Debug.Log(FortuneValue);

        
    }

    public void addFortuneGauge(float point)
    {
        FortuneValue += point;
    }
    
    
    
}
