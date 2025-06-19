using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    // public Image hpGaugeImage;
    public int life = 3;
    public GameObject heartImage1;
    public GameObject heartImage2;
    public GameObject heartImage3;
    // E問題
    public TextMeshProUGUI _timeText;
    public static float delta = 0;

    void Start()
    {
        delta = 0;
    }

    // E問題
    void Update()
    {
        delta += Time.deltaTime;
        _timeText.text = $"Time: {delta}";
    }

    public void DecreaseHP()
    {
        life--;
        if (life == 2)
        {
            heartImage3.SetActive(false);
        }
        else if (life == 1)
        {
            heartImage2.SetActive(false);
        }
        else if (life == 0)
        {
            heartImage1.SetActive(false);
        }
        else if (life == -1)
        {
            SceneManager.LoadScene("Result");
        }
    }

    // 名城学生問題(ハートの画像を表示するのはDecreaseHPでも同じ処理なので，関数化できると良いですね)
    public void RecoveryHP()
    {
        if (life < 3)
        {
            life++;
        }

        if (life == 3)
        {
            heartImage3.SetActive(true);
        }
        else if (life == 2)
        {
            heartImage2.SetActive(true);
        }
        else if (life == 1)
        {
            heartImage1.SetActive(true);
        }

    }
}
