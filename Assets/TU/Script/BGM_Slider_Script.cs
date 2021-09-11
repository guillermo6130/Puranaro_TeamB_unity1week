using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Slider_Script : MonoBehaviour
{   
    //音量調整用スライダー
    Slider m_Slider;

    [SerializeField]
    //キー入力で調整バーを動かせるようにするか
    bool m_isInput;
    [SerializeField]
    //キー入力で調整バーを動かすスピード
    float m_ScroolSpeed = 1;
    private void Awake()
    {
        m_Slider = GetComponent<Slider>();
        m_Slider.value = AudioListener.volume;
    }

    private void OnEnable()
    {
        m_Slider.value = AudioListener.volume;
        //スライダーの値が変更されたら音量も変更する
        m_Slider.onValueChanged.AddListener((sliderValue) => AudioListener.volume = sliderValue);
    }

    private void OnDisable()
    {
        m_Slider.onValueChanged.RemoveAllListeners();
    }

    //キー入力による操作　不要なら削除する
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
