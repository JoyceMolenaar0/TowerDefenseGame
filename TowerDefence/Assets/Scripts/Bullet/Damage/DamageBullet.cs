using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
    [SerializeField] int DamageCount;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider Colliders)
    {
       

        if (Colliders.gameObject.tag == "Enemy")
        {
            EnemyHealth EnemyHealthScript = Colliders.gameObject.GetComponentInChildren<EnemyHealth>();
            Debug.Log("Enemy Hit!");
            EnemyHealthScript.TakeDamage(DamageCount);
        }
    }

}
