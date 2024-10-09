using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneEnemy : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    private GameObject EnemyClone;

    private float ElapsedTime;
    private float EnemyCount = 1f;
    void Start()
    {

    }


    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 3 && EnemyCount < 5)
        {
            EnemyClone = Instantiate(Enemy);
            ElapsedTime = 0;
            EnemyCount++;
        }
    }
}
