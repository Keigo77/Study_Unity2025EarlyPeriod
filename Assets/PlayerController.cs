using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    
    void Start()
    {
        Application.targetFrameRate = 60;
        playerRB = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 左矢印が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.velocity = new Vector2(-3, 0);      // 速度移動に変更
        }

        // 右矢印が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.velocity = new Vector2(3, 0);      // 速度移動に変更
        }

        if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false)
        {
            playerRB.velocity = new Vector2(0, 0);
        }
    }
}
