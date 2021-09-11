using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitleScript : MonoBehaviour
{
    public void OnClickOptionButton()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
