using UnityEngine;

public class WalkScript : MonoBehaviour
{
    public GameObject EnemyStart;
    public GameObject EnemyEnd;
    public Transform[] points;
    public float WalkSpeed = 2f; 
    private int WalkPoints = 0;
    private float RotationSpeed = 0.3f;
   
    

    private void Start()
    {
        transform.position = EnemyStart.transform.position;

    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, EnemyEnd.transform.position) < 0.01f)
        {
            Destroy(gameObject);
            return;
        }

        if (points.Length == 0) return;
        transform.position = Vector3.MoveTowards(transform.position, points[WalkPoints].position, WalkSpeed * Time.deltaTime);
        transform.LookAt(points[WalkPoints].position);

        if (Vector3.Distance(transform.position, points[WalkPoints].position) < 0.01f)
        {
           
            WalkPoints++;
            if (WalkPoints >= points.Length)
            {
                WalkPoints = 0;
            }
        }


        

    }
}