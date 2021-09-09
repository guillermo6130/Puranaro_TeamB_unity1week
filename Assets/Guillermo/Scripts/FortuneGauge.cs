using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortuneGauge : MonoBehaviour
{
    [SerializeField] GameObject Handle;
    HandleController HandleController;

    float FortuneValue=0;
    [SerializeField]float maxFortuneValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        HandleController = Handle.GetComponent<HandleController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FortuneInc()
    {
        FortuneValue += HandleController.getRotateNum();
        FortuneValue /= maxFortuneValue;

    }

    
    
    
}
