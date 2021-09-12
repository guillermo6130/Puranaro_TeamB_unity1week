using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Slider_Script : MonoBehaviour
{   
    //���ʒ����p�X���C�_�[
    Slider m_Slider;

    [SerializeField]
    //�L�[���͂Œ����o�[�𓮂�����悤�ɂ��邩
    bool m_isInput;
    [SerializeField]
    //�L�[���͂Œ����o�[�𓮂����X�s�[�h
    float m_ScroolSpeed = 1;
    private void Awake()
    {
        m_Slider = GetComponent<Slider>();
        m_Slider.value = AudioListener.volume;
    }

    private void OnEnable()
    {
        m_Slider.value = AudioListener.volume;
        //�X���C�_�[�̒l���ύX���ꂽ�特�ʂ��ύX����
        m_Slider.onValueChanged.AddListener((sliderValue) => AudioListener.volume = sliderValue);
    }

    private void OnDisable()
    {
        m_Slider.onValueChanged.RemoveAllListeners();
    }

    //�L�[���͂ɂ�鑀��@�s�v�Ȃ�폜����
    // Update is called once per frame
    void Update()
    {
        float v = m_Slider.value;
        if (m_isInput)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                v -= m_ScroolSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
            {
                v += m_ScroolSpeed * Time.deltaTime;
            }
        }
        v = Mathf.Clamp(v, 0, 1);
        m_Slider.value = v;
    }
}
