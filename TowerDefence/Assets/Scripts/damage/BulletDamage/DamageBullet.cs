using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamageBullet : MonoBehaviour
{
    [SerializeField] int HealthBarScript;
    [SerializeField] int Damage;
    [SerializeField] Transform Enemy;
    void Start()
    {
        
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, Enemy.transform.position) < 1f)
        {
            TakeDamage(Damage);
        }
    }

    void TakeDamage(int TheDamage)
    {
        Damage -= Damage;  
    }

    
}
