using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyThings : MonoBehaviour
{
    KeyText textUI;

    int keyNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        textUI = FindObjectOfType<KeyText>();
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
        textUI.KeyNum(keyNum);
        print("Number of keys: " + keyNum);
    }

    public void SubtractKey()
    {
        --keyNum;
        textUI.KeyNum(keyNum);
    }

}
