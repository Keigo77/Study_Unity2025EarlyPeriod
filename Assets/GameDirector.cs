using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGaugeImage;

    public void DecreaseHP()
    {
        hpGaugeImage.fillAmount -= 0.1f;
    }
}
