using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorDelete : MonoBehaviour
{
    KeyThings key;
    // Start is called before the first frame update
    void Start()
    {
        key = FindObjectOfType<KeyThings>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                // do nothing, someone I like
                if (key.KeyCheck())
                {
                    key.SubtractKey();
                    Destroy(gameObject);
                }
                
                break;
        }
    }
    public void deleteDoor()
    {
        Destroy(gameObject);
    }
}
