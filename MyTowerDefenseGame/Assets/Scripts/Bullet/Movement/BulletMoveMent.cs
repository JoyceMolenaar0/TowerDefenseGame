using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMoveMent : MonoBehaviour
{
    [SerializeField] int BulletSpeed;

    private Vector3 EnemyPosition;
    void Start()
    {
        GameObject Enemy = GameObject.FindWithTag("Enemy");

        if (Enemy != null)
        {
            EnemyPosition = Enemy.transform.position;
        }
        else
        {
            DestroyBullet();
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, EnemyPosition, BulletSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, EnemyPosition) < 0.5f)
        {
            DestroyBullet();
        }
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
        return;
    }
}
