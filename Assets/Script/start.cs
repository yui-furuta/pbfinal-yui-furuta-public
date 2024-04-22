using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class start : MonoBehaviour
{
    float countTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
          if(countTime>3.0f)
          {
             SceneManager.LoadScene ("opening");
          }

          if(Input.anyKey) 
        {
            SceneManager.LoadScene ("opening"); 
        }
    }
}
