using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] GameObject BulletSpawn;
    [SerializeField] float BulletSpeed;
    private Vector3 EnemyPos;
    
    void Start()
    {
        transform.position = BulletSpawn.transform.position;
        
        GameObject Enemy = GameObject.FindWithTag("Enemy");
        if (Enemy != null)
        {
            EnemyPos = Enemy.transform.position;
        }
       
    }

   
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, EnemyPos, BulletSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, EnemyPos) < 0.5)
        {
            Destroy(gameObject);
        }

    }
}
