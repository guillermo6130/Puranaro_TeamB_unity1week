using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButtonScript : MonoBehaviour
{
    public void OnClickOptionButton() 
    {
        SceneManager.LoadScene("OptionScene");
    }
}
