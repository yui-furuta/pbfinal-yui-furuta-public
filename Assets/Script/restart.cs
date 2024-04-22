using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 追加
using UnityEngine.SceneManagement; // 追加

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey) 
        {
            SceneManager.LoadScene ("opening"); 
        }
        
    }
   
   

}
