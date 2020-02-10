using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    GameObject Cam;
    public Vector3 mousePos;
    public float speed = 2.0f;
    public float moveSpeed = 4.0f;
    public bool moveVertical;

   // public event test;




    // Start is called before the first frame update
    void Start()
    {
        Cam =  GameObject.FindWithTag("MainCamera");
        moveVertical = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveSpeed < 0)
        {
            moveSpeed = 0;
        }


        mousePos =  Cam.transform.rotation.eulerAngles;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 pos = Cam.transform.position + Cam.transform.forward * moveSpeed;
            Debug.Log(pos.ToString());
            Cam.transform.position = pos;

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 pos = (Cam.transform.position + Cam.transform.forward * -moveSpeed);
            Debug.Log(pos.ToString());
            Cam.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 pos = (Cam.transform.position + Cam.transform.right * moveSpeed);
            Debug.Log(pos.ToString());
            Cam.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 pos = (Cam.transform.position + Cam.transform.right * -moveSpeed);
            Debug.Log(pos.ToString());
            Cam.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {

            float X = Cam.transform.eulerAngles.x-Input.GetAxis("Mouse Y")*speed;
            float Y = Cam.transform.eulerAngles.y + Input.GetAxis("Mouse X")*speed;
            Cam.transform.eulerAngles = new Vector3(X, Y, 0f);


            Debug.Log(Cam.transform.forward.ToString());
            //Debug.Log(mousePos.x);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 pos = (Cam.transform.position + Cam.transform.up * speed);
            Debug.Log("HA");
            Cam.transform.position = pos;
        }





        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            moveSpeed += 0.01f;           
        }
        if (Input.GetKey(KeyCode.KeypadMinus) && moveSpeed > 0)
        {
            moveSpeed -= 0.01f;
        }
    }
}