using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 // 名城学生問題
public class OrangeController : MonoBehaviour
{
    AudioSource audioSource;    // AudioSource型の変数
    public AudioClip Se;        // AudioClip型の変数．ここに.mp3をアサインする

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
            Debug.Log("回復");

            // 監督スクリプトに，プレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().RecoveryHP();
            // 効果音を鳴らすため，AudioSourceを取得
            audioSource = collision.GetComponent<AudioSource>();
            audioSource.PlayOneShot(Se);

            Destroy(this.gameObject);
        }
    }
}
