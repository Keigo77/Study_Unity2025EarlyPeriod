using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject orangePrefab;
    public float span = 1.0f;
    float delta = 0;
    
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;

            int randomNum = Random.Range(0, 10);
            GameObject go;

            if (randomNum == 0){
                go = Instantiate(orangePrefab);
            } else {
                go = Instantiate(arrowPrefab);
            }
            
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
