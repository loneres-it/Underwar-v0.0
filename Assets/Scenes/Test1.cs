using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test1 : MonoBehaviour
{

    MainCamera cam;
    Canvas UI;
    Text UI_SPEED;
    Text UI_COORD;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<MainCamera>();
        UI = FindObjectOfType<Canvas>();
        Debug.Log(cam.tag);
        Debug.Log(UI.tag);


        var UIText = UI.GetComponentsInChildren<Text>();
        foreach (Text ui_c in UIText)
        {
            switch (ui_c.name){
                case "UI_SPEED": UI_SPEED = ui_c; break;
                case "UI_COORD": UI_COORD = ui_c; break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Unity
        if (cam!=null && UI!=null)
        {
            UI_SPEED.text = cam.moveSpeed.ToString();
            UI_COORD.text = cam.transform.position.ToString();
        }
        else
        {
            Debug.Log("EMPTY");
        }
    }
}
