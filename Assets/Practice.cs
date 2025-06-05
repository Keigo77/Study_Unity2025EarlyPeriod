using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    float area;
    float inputRadius = 2.0f;
    
    void Start()
    {
        Debug.Log("面積を計算します");
        area = CalculateArea(inputRadius);
        Debug.Log(area);
    }

    float CalculateArea(float radius)
    {
        return radius * radius * 3.14f;
    }
}
