using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    private float SpawnRadius = 1f;
    private LayerMask CollisionLayer;
    void Start()
    {
       RandomPlace();
    }

     
    void Update()
    {
        
    }

    void RandomPlace()
    {
        bool GotPosition = false;

        while (!GotPosition)
        {
            float X = Random.Range(-1.9f,1.16f);
            float Y = 0f;
            float Z = 0f; ;

            Vector3 RandomPos = new Vector3(X, Y, Z);
            transform.position = RandomPos;
            if (!Physics.CheckSphere(RandomPos, SpawnRadius, CollisionLayer))
            {
                transform.position = RandomPos;
                GotPosition = true;
            }
        }

    }
}
