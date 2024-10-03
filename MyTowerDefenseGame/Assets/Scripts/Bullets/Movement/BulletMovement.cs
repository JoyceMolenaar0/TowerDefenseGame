using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] Transform Enemy;
    [SerializeField] GameObject[] WalkPoints = new GameObject[10];

    private float BulletSpeed = 2f;
    void Start()
    {
        
    }
    void Update()
    {
        if ((Vector3.Distance(Enemy.transform.position, WalkPoints[1].transform.position) < 0.2f))
        {
            transform.position = Vector3.MoveTowards(transform.position, WalkPoints[1].transform.position, BulletSpeed * Time.deltaTime);
        }

    }
}
