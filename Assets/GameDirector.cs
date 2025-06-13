using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // public Image hpGaugeImage;
    public int life = 3;
    public GameObject heartImage1;
    public GameObject heartImage2;
    public GameObject heartImage3;

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
    }
}
