using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float ElapsedTime = 0f;
    private GameObject NewEnemy;

    MaxEnemies maxEnemies;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject EndPos;
    void Start()
    {
        maxEnemies = GetComponent<MaxEnemies>();
         
    }
    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 3f)
        { 
            if (maxEnemies.EnemyCount < 5f)
            {
                CreateNewEnemy();
                ElapsedTime = 0f;
            }
        }
    }

   public void CreateNewEnemy()
    {
        NewEnemy = Instantiate(Enemy);
        maxEnemies.EnemyCount++;
        if (Vector3.Distance(transform.position, EndPos.transform.position) < 0.01f)
        {
            DestroyEnemy();
        }
    }

   public void DestroyEnemy()
    {
        Destroy(NewEnemy);
    }
}
