using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject[] WalkPoints;
    [SerializeField] int CurrentTarget;
    private float MoveSpeed = 2;
    void Start()
    {
        transform.position = WalkPoints[0].transform.position;
        if (CurrentTarget > 0)
        {
            CurrentTarget = 0;
        }

    }


    void Update()
    {
        Move();  
        if (Vector3.Distance(transform.position, WalkPoints[11].transform.position) < 0.5)
        {
            Destroy(gameObject);
            return;
        }
    }

    void Move()
    {
        if (CurrentTarget >= WalkPoints.Length) return;
        Vector3 Target = WalkPoints[CurrentTarget].transform.position;
        transform.position = Vector3.MoveTowards(transform.position, WalkPoints[CurrentTarget].transform.position, MoveSpeed * Time.deltaTime);
        transform.LookAt(Target);
        if (Vector3.Distance(transform.position, WalkPoints[CurrentTarget].transform.position) < 0.2)
        {
            Debug.Log("WayPoint: " + CurrentTarget);
            CurrentTarget++;
        }
    }



}
