using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyText : MonoBehaviour
{

    Text keyText;
    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponent<Text>();
        keyText.text = "Keys: 0";
    }

    public void KeyNum(int num)
    {
        keyText.text = "Keys: " + num;
    }
    
}
