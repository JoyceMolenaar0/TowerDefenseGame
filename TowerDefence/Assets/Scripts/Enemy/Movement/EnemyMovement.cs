using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject[] WalkPoints;
    [SerializeField] int CurrentTarget;
    [SerializeField] float MoveSpeed = 0.7f;

    private float ElapsedTime = 0f;
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
        ElapsedTime += Time.deltaTime;
        Move();
    }

    void Move()
    {
        if (ElapsedTime < 15)
        {
            MoveToDoor();
        }
        else
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

            if (Vector3.Distance(transform.position, WalkPoints[11].transform.position) < 0.5)
            {
                Destroy(gameObject);
                return;
            }
        }
        
    }

    void MoveToDoor()
    {
        transform.position = Vector3.MoveTowards(transform.position, WalkPoints[1].transform.position, MoveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, WalkPoints[1].transform.position) < 0.2)
        {
            CurrentTarget = 1;
        }
    }



}
