using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    public void OnTriggerEnter(Collider Colliders)
    {
        if (Colliders.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
