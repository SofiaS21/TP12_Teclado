using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public Key[] keys;


    // Start is called before the first frame update
    void Start()
    {
        keys = GameObject.FindObjectsOfType<Key>();
    }

    void DestroyKey()
    {
        int randomIndex

        Destroy(keys[randomKey].gameObject);
    }
}
