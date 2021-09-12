using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFortuneBall : MonoBehaviour
{
    [Range(0, 9)]
    [SerializeField] float MaxX;

    [Range(-9, 0)]
    [SerializeField] float MinX;

    [Range(0, 9)]
    [SerializeField] float MaxY;

    [Range(-9, 0)]
    [SerializeField] float MinY;
    [SerializeField] float z;

    [SerializeField]GameObject FortuneBall;
    [SerializeField]GameObject unFortuneBall;

    string[] UDLR= {"Up","Down","Left","Right"};

    float posX;
    float posY;

    [SerializeField] float percentage_ball;
    [SerializeField]float percentageNow;

    [SerializeField] float CreateSecond=0.1f;
    [SerializeField] float createSecondNow;
    [SerializeField] float busrtSecond;
    float CreateCount = 0;

    private void Start()
    {
        percentageNow = percentage_ball;
        createSecondNow = CreateSecond;
    }
    // Update is called once per frame
    void Update()
    {
        CreateCount += Time.deltaTime;
        if (CreateCount >= createSecondNow)
        {
            CreateCount = 0;
            CreateBall();
        }
        
    }

    void CreateBall()
    {
        setPosition();
        float chooseball=Random.value;
        if (chooseball < percentageNow)
        {
            Instantiate(FortuneBall,new Vector3(posX,posY,z),Quaternion.identity);
        }
        else
        {
            Instantiate(unFortuneBall, new Vector3(posX, posY, z), Quaternion.identity);
        }


    }

    void setPosition()
    {
        string place = ChooseUDLR();
        if (place == "Up")
        {
            posY = MaxY;
            posX = chooseX();
        }
        else if (place == "Down")
        {
            posY = MinY;
            posX = chooseX();
        }
        else if (place == "Right")
        {
            posX = MaxX;
            posY = chooseY();
        }
        else
        {
            posX = MinX;
            posY = chooseY();
        }
    }
    float chooseX()
    {
        return Random.Range(MinX, MaxX);
    }

    float chooseY()
    {
        return Random.Range(MinY, MaxY);
    }
    string ChooseUDLR()
    {
        int chosenOne = Random.Range(0, UDLR.Length);
        return UDLR[chosenOne];

    }

    public void set100Percent()
    {
        percentageNow = 1;
    }

    public void returnPercent()
    {
        percentageNow = percentage_ball;
    }

    public void setCreateSecond()
    {
        createSecondNow = busrtSecond;
    }

    public void returnCreateSecond()
    {
        createSecondNow = CreateSecond;
    }
}
