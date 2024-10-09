using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    [SerializeField] GameObject[] Walkpoints = new GameObject[10];
    [SerializeField] float WalkSpeed = 4f;

    private int CurrentWalkPoint;
    private int RotationSpeed;
    void Start()
    { 
        transform.position = Walkpoints[0].transform.position;
        CurrentWalkPoint = 0;
    }

    
    void Update()
    {
        StartWalk();

        if (Vector3.Distance(transform.position, Walkpoints[9].transform.position) < 0.5f)
        {
            Destroy(gameObject);
            return;
        }
    }

    void StartWalk()
    {
        Vector3 TargetWalkpoints = Walkpoints[CurrentWalkPoint].transform.position;

        transform.position = Vector3.MoveTowards(transform.position, TargetWalkpoints, WalkSpeed * Time.deltaTime);
        transform.LookAt(TargetWalkpoints);

        if (Vector3.Distance(transform.position, TargetWalkpoints) < 0.1f)
        {
            CurrentWalkPoint++;
        }
    }
}
