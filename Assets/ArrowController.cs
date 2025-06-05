using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    void Update()
    {
        // 1フレームごとに0.1ずつ落ちていく
        this.transform.Translate(0, -0.1f, 0);
        
        // 画面外に出たらオブジェクトを破壊する
        if (this.transform.position.y < -5.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("矢に当たった！");
            
            // 監督スクリプトに，プレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();
            
            Destroy(this.gameObject);
        }
    }
}
