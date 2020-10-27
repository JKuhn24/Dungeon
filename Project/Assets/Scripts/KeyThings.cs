using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyThings : MonoBehaviour
{
    int keyNum = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool KeyCheck()
    {
        if (keyNum >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddKey()
    {
        ++keyNum;
        print("Number of keys: " + keyNum);
    }

    public void SubtractKey()
    {
        --keyNum;
    }

}
