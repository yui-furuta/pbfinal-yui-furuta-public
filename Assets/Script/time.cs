using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    public float countdown = 60.0f;
 
    public Text timeText;
    void Start()
    {
        
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f1");
    }
}
