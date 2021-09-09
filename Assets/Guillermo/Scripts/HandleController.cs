using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleController : MonoBehaviour
{

    Vector3 pos; // �ŏ��ɃN���b�N�����Ƃ��̈ʒu
    Quaternion rotation; // �ŏ��ɃN���b�N�����Ƃ���Box�̊p�x

    Vector2 vecA; // Box�̒��S����pos�ւ̃x�N�g��
    Vector2 vecB; // Box�̒��S���猻�݂̃}�E�X�ʒu�ւ̃x�N�g��

    float angle = 0; // vecA��vecB�������p�x
    Vector3 AxB; // vecA��vecB�̊O��

    
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

    // �N���b�N���Ƀp�����[�^�̏����l�����߂�
    public void SetPos()
    {
        pos = SubCamera.ScreenToWorldPoint(Input.mousePosition); // �}�E�X�ʒu�����[���h���W�Ŏ擾
        rotation = transform.parent.rotation; // Box�̌��݂̊p�x���擾
    }

    // �n���h�����h���b�O���Ă���ԂɌĂяo��
    public void Rotate()
    {
        calculateAngle();
        transform.parent.localRotation = rotation * Quaternion.Euler(0, 0, angle); // �����l�Ƃ̊|���Z�ő��ΓI�ɉ�]������ 
    }

    public void calculateAngle()
    {
        vecA = pos - (Vector3)transform.parent.position; //����n�_����̃x�N�g�������߂�Ƃ��͂��������񂾂���
        vecB = SubCamera.ScreenToWorldPoint(Input.mousePosition) - transform.parent.position; // ��ɓ�����
        // Vector2�ɂ��Ă���̂�z���W�����������Ȃ��悤�ɂ��邽�߂ł�

        angle = Vector3.Angle(vecA, vecB); // vecA��vecB�������p�x�����߂�
        AxB = Vector3.Cross(vecA, vecB); // vecA��vecB�̊O�ς����߂�
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
