using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Collider)
    {
        if (gameObject.tag == "Bullet")
        {
            Debug.Log("Collision");
        }
    }
}
