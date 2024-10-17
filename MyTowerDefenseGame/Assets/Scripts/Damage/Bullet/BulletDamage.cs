using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamage : MonoBehaviour
{
    EnemyHealth EnemyHealthScript;
    [SerializeField] Transform Enemy;
    [SerializeField] int TheDamage;

    private int BulletCoinsCount = 0;

    void Start()
    {
        EnemyHealthScript = Enemy.GetComponent<EnemyHealth>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Colliders)
    {
        if (Colliders.CompareTag("Enemy"))
        {
            EnemyHealthScript.TakeDamage(TheDamage);
            EnemyHealthScript.UpdateHP();
            BulletCoinsCount++;
        }
    }
}