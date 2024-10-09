using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamageBullet : MonoBehaviour
{
    HealthEnemy HealthEnemyScript;
    [SerializeField] int DamageCount;
    private Vector3 EnemyPosition;
    void Start()
    {
        HealthEnemyScript = GetComponent<HealthEnemy>();
    }

    void Update()
    {
        GameObject Enemy = GameObject.FindWithTag("Enemy");
        EnemyPosition = Enemy.transform.position;

        if (Vector3.Distance(transform.position, EnemyPosition) < 0.5)
        {
            HealthEnemyScript.Damage(DamageCount);
        }

    }
}
