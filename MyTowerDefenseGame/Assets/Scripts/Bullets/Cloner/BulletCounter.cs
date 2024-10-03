using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCounter : MonoBehaviour
{
    BulletClone BulletCloneScript;
    void Start()
    {
        BulletCloneScript = FindObjectOfType<BulletClone>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider EnemyColl)
    {
        if (EnemyColl.gameObject.tag == "Enemy")
        {
 
        }
    }
}
