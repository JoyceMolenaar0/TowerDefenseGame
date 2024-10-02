using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
    EnemyHealth EnemyHealthScript;

    [SerializeField] Transform Enemy;
    void Start()
    {
        EnemyHealthScript = FindObjectOfType<EnemyHealth>();
        EnemyHealthScript.TakeDamage(50);
    }

    
    void Update()
    {
        

    }


}
