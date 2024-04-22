using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class character2 : MonoBehaviour
{

    public float speed;
    bool isShot;
    private Animator anim = null;
    float countTime = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        isShot = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ang = this.transform.localEulerAngles;
        Vector3 goal = transform.position;  

        if(isShot == false)
       {
                if(Input.GetKeyDown(KeyCode.UpArrow))
                {
                    ang.z = 0;
                    isShot = true;
                }
                
                if(Input.GetKeyDown(KeyCode.RightArrow))
                {
                    ang.z = -90;
                    isShot = true;
                }

                if(Input.GetKeyDown(KeyCode.DownArrow))
                {
                    ang.z = -180;
                    isShot = true;
                }

                if(Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    ang.z = -270;
                    isShot = true;
                }

                transform.localEulerAngles = ang;
        }



        if(isShot == true)
        {
           transform.Translate(Vector3.up * speed); 
           anim.SetBool("go",true);
        }
         

         if(goal.y>=6.0f)
         {
            goal.x = -4.5f;
            goal.y = -4.5f;
            transform.position = goal;   
            SceneManager.LoadScene ("next1");
         }

          countTime += Time.deltaTime;
          if(countTime>30.0f)
          {
              SceneManager.LoadScene ("gameover");
          }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isShot = false;
        Vector3 pos = transform.position;
        transform.Translate(0,-0.1f,0);
        anim.SetBool("go",false);
    }

}
