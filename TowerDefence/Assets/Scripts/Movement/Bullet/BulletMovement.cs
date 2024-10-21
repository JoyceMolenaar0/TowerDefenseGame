using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float BulletSpeed;
    private Vector3 Enemy;
    void Start()
    {
        GameObject enemy = GameObject.FindWithTag("Enemy");
        if (enemy != null)
        {
            Enemy = enemy.transform.position;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Enemy, BulletSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, Enemy) < 0.2f)
        {
            Destroy(gameObject);
        }
    }
}
