using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uzukaitenScript : MonoBehaviour
{
    public float speed = 10f; //回転する速度を設定します。マイナス値にすると、逆回転になります。

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);　//設定した速さで、Y軸に回転します
    }
}
