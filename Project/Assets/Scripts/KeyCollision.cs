using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
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
        key.AddKey();
        Destroy(gameObject);
        print("Hit");
    }
}
