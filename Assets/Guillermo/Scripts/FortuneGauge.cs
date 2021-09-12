using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortuneGauge : MonoBehaviour
{
    [SerializeField] GameObject Handle;
    HandleController HandleController;
    [SerializeField] GameObject creation;
    CreateFortuneBall createFortuneBall;

    Slider slider;
    float FortuneValue=0;
    float preRotateNum=0;

    [SerializeField]float maxFortuneValue = 100;
    bool FortuneBurst=false;
    [SerializeField]float FortuneBurstValue = 3f;

    [SerializeField]float RotateVar = 4;

    // Start is called before the first frame update
    void Start()
    {
        HandleController = Handle.GetComponent<HandleController>();
        slider = this.GetComponent<Slider>();

        createFortuneBall = creation.GetComponent<CreateFortuneBall>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FortuneValue < maxFortuneValue&&FortuneBurst==false)
        {
            FortuneIncByRotateNum();
        }
        else if (FortuneValue >= maxFortuneValue)
        {
            FortuneBurst = true;
            createFortuneBall.set100Percent();
            createFortuneBall.setCreateSecond();
        }
        if (FortuneBurst == true)
        {
            FortuneValue -= FortuneBurstValue;
            if (FortuneValue <= 0)
            {
                FortuneBurst = false;
                FortuneValue = 0;
                createFortuneBall.returnPercent();
                createFortuneBall.returnCreateSecond();
            }
        }
        //Debug.Log(FortuneValue);
        slider.value = FortuneValue / maxFortuneValue;
    }

    public void FortuneIncByRotateNum()
    {
        float IncRotateNum = 0;
        IncRotateNum = HandleController.getRotateNum();
        FortuneValue += (IncRotateNum-preRotateNum)*RotateVar;
        preRotateNum = HandleController.getRotateNum();
        //Debug.Log(FortuneValue);

        
    }

    public void addFortuneGauge(float point)
    {
        FortuneValue += point;
    }

   
    
    
    
}
