using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleController : MonoBehaviour
{

    Vector3 pos; // 最初にクリックしたときの位置
    Quaternion rotation; // 最初にクリックしたときのBoxの角度

    Vector2 vecA; // Boxの中心からposへのベクトル
    Vector2 vecB; // Boxの中心から現在のマウス位置へのベクトル

    float angle = 0; // vecAとvecBが成す角度
    Vector3 AxB; // vecAとvecBの外積

    
    [SerializeField] private Camera SubCamera;

    private bool isMouseOnHandle = false;
    private bool isHandling = false;
    private bool isMouseMoving = true;

    [SerializeField] GameObject HandleObject;

    private Vector3 mousePosPre = Vector3.zero;
    private float cursorTimer;
    [SerializeField] float mousecheckTime = 0.2f;

    float AngleSpeed=0;
    float RotateNum = 0;
    float rotation_Handle = 0;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isMouseOnHandle)
        {
            isHandling = true;
            SetPos();
        }
        else if (Input.GetMouseButton(0) && isHandling)
        {
            //Debug.Log(Input.mousePosition);
            Rotate();
            Invoke("calc_set", 0.1f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isHandling = false;
            SetPos();
            Rotate();
            
        }
        else
        {
            
        }
        HandleMouse();
        //Debug.Log(angle);

        MouseUpdate();
        //Debug.Log(isMouseMoving);

    }

    // クリック時にパラメータの初期値を求める
    public void SetPos()
    {
        pos = SubCamera.ScreenToWorldPoint(Input.mousePosition); // マウス位置をワールド座標で取得
        rotation = transform.parent.rotation; // Boxの現在の角度を取得
    }

    // ハンドルをドラッグしている間に呼び出す
    public void Rotate()
    {
        calculateAngle();
        transform.parent.localRotation = rotation * Quaternion.Euler(0, 0, angle); // 初期値との掛け算で相対的に回転させる 
    }

    public void calculateAngle()
    {
        vecA = pos - (Vector3)transform.parent.position; //ある地点からのベクトルを求めるときはこう書くんだった
        vecB = SubCamera.ScreenToWorldPoint(Input.mousePosition) - transform.parent.position; // 上に同じく
        // Vector2にしているのはz座標が悪さをしないようにするためです

        angle = Vector3.Angle(vecA, vecB); // vecAとvecBが成す角度を求める
        AxB = Vector3.Cross(vecA, vecB); // vecAとvecBの外積を求める
        if (!(AxB.z > 0))
        {
            angle = -angle;
        }

        //calculateAnglespeed();

    }

    public void calculateAnglespeed()
    {
        AngleSpeed = angle / Time.deltaTime;
        //Debug.Log(AngleSpeed);
    }

    public void calc_set()
    {
        calc_rotate_num();
        calculateAnglespeed();
        SetPos();
    }

    public void calc_rotate_num()
    {
        rotation_Handle += angle;
        if (rotation_Handle >= 360)
        {
            rotation_Handle = 0;
            RotateNum += 1;
        }
        else if (rotation_Handle <= -360)
        {
            rotation_Handle = 0;
            RotateNum += 1;
        }
        //Debug.Log(RotateNum);
        //Debug.Log(rotation_Handle);
        //Debug.Log(angle);
    }
    public void MouseUpdate()
    {
        Vector3 mousePos = Input.mousePosition;

        if (mousePos != mousePosPre)
        {
            isMouseMoving = true;
            cursorTimer = 0.0f;
        }
        else
        {
            if (cursorTimer >= mousecheckTime)
            {
                isMouseMoving = false;
            }
            else
            {
                cursorTimer += Time.deltaTime;
            }
        }

        mousePosPre = mousePos;
    }

    public void HandleMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit_info = new RaycastHit();
        float max_distance = 100f;

        bool is_hit = Physics.Raycast(ray, out hit_info, max_distance);

        if (is_hit)
        {
            if (hit_info.transform.name == HandleObject.name)
            {
                //Debug.Log("HandleHit");
                isMouseOnHandle = true;
            }
        }
        else
        {
            isMouseOnHandle = false;
        }
    }

    public float getAngleSpeed()
    {
        return AngleSpeed;
    }

    public float getRotateNum()
    {
        return RotateNum;
    } 
}
