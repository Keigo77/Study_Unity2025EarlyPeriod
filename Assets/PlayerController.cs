using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 左矢印が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.05f, 0, 0);     // 左に「3」動かす
        }

        // 右矢印が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.05f, 0, 0);      // 右に「3」動かす
        }
    }
}
