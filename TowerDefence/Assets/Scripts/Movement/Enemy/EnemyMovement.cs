using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject[] WalkPoints;

    private int CurrentTarget;
    private int MoveSpeed = 2;
    void Start()
    {
        transform.position = WalkPoints[0].transform.position;
    }

    
    void Update()
    {
        
    }

    public void Move()
    {
        Vector3 Target = WalkPoints[CurrentTarget].transform.position;

        transform.position = Vector3.MoveTowards(transform.position, WalkPoints[CurrentTarget].transform.position, MoveSpeed * Time.deltaTime);
        transform.LookAt(Target);

        if (Vector3.Distance(transform.position, WalkPoints[CurrentTarget].transform.position) < 0.5)
        {
            CurrentTarget++;
        }
    }
}
