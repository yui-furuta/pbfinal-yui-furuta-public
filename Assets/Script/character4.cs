using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 追加
using UnityEngine.SceneManagement; // 追加

public class character4 : MonoBehaviour
{

    public float speed;
    private Animator anim = null;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ang = this.transform.localEulerAngles;
        Vector3 goal = transform.position;  

           transform.Translate(Vector3.up * speed); 
           anim.SetBool("go",true);
         
         if(goal.x>=4.0f)
         {
            SceneManager.LoadScene ("second");
         }
    }


}
