using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowResult : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    
    void Start()
    {
        resultText.text = $"Time: {GameDirector.delta}";
    }
}
