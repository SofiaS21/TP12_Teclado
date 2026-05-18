using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    bool pressed = false;
    float pressedOffset = 0.5f;

    void OnMouseDown(){
        Debug.Log("Click en " + gameObject.name);
        transform.Translate(0,-pressedOffset,0);
        pressed = true;
    }

    void OnMouseUp()
    {
        if(pressed){
            transform.Translate(0,pressedOffset,0);
            pressed = false;
        }
    }

     void OnMouseExit()
    {
        if(pressed){
            transform.Translate(0,pressedOffset,0);
            pressed = false;
        }
    }

}
