using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxEnemies : MonoBehaviour
{
    EnemySpawner enemySpawner;
    public float EnemyCount = 0f;

    void Start()
    {
       enemySpawner = GetComponent<EnemySpawner>();
    }

    
    void Update()
    {
        if (EnemyCount == 5f)
        {
            NoMoreClones();
        }
    }

    void NoMoreClones()
    {
        enemySpawner.DestroyEnemy();
    }
}
