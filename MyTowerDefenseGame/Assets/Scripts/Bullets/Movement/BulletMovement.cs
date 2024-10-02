using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float BulletSpeed = 4f;
    private float ElapsedTime = 0;
    [SerializeField] Transform Enemy;
    [SerializeField] GameObject WalkPoint1;
    void Start()
    {
        
    }


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position, BulletSpeed * Time.deltaTime);

        
    }

    private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            return;
        }
    }
}
