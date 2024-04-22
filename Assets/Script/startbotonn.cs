using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbotonn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
       Vector3 pos = transform.position;
        transform.Translate(0,0,1.0f);
    }

    void OnMouseExit()
    {
        Vector3 pos = transform.position;
        transform.Translate(0,0,-1.0f);
    }

}
