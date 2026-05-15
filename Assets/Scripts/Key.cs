using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnMouseDown(){
        Debug.Log("Click en " + gameObject.name);
    }
}
