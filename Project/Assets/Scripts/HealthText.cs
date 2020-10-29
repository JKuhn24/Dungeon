using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{

    Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        healthText.text = "Health: 100";
    }

    public void HPNum(int num)
    {
        healthText.text = "Health: " + num;
    }
}
