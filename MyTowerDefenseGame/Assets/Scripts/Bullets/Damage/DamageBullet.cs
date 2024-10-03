using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
 
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.gameObject.tag == "Enemy")
        { 
            EnemyHealth EnemyHealthScript = Enemy.GetComponent<EnemyHealth>();

            if (EnemyHealthScript != null)
            {
                EnemyHealthScript.TakeDamage(10);
            }
        }
    }


}
