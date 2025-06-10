using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    Vector3 enemyPosition;
    
    void Start()
    {
        enemyPosition = GetEnemyPosition("ピカチウ");
        Debug.Log(enemyPosition);
    }

    Vector3 GetEnemyPosition(string enemyName)
    {
        if (enemyName == "ピカチュウ")
        {
            return new Vector3(3.6f, -21.6f, 9.7f);
        } 
        else if (enemyName == "ニャース")
        {
            return new Vector3(-1.0f, 9.3f, 5.2f);
        }
        else
        {
            return new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
