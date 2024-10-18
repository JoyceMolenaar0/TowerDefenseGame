using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] GameObject StartingPos;
    [SerializeField] GameObject EnemyPoint;
    private Vector3 TargetPos;
    private GameObject Enemy;
    private float BulletSpeed = 2f;


     void Start()
    {
        transform.position = StartingPos.transform.position;

        Enemy = GameObject.FindWithTag("Enemy");
        if (Enemy != null)
        {
            TargetPos = Enemy.transform.position;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPos, BulletSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, TargetPos) < 0.5)
        {
            Destroy(gameObject);
        }
    }
}
