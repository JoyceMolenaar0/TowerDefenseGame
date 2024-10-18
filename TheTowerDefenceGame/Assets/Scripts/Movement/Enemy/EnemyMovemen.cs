using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovemen : MonoBehaviour
{
    [SerializeField] GameObject[] WalkPoints; 

    private int Target = 0; 
    private float MoveSpeed = 2f; 

void Start()
{

        transform.position = WalkPoints[0].transform.position;
}

void Update()
{
  
}

void Move()
{
    
    if (WalkPoints.Length == 0)
    {
        return; 
    }
    Vector3 targetPosition = WalkPoints[Target].transform.position;
    transform.position = Vector3.MoveTowards(transform.position, targetPosition, MoveSpeed * Time.deltaTime);

    if (Vector3.Distance(transform.position, targetPosition) < 0.5f)
    {
        Target++; 

        
    }
}
}
