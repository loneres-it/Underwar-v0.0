using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_colliding : MainCamera
{
    CapsuleCollider coll1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("dddd");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("touched");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
