using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicates : MonoBehaviour
{
    [SerializeField] GameObject EnemyOger;
    private GameObject OgerClone;

    private float ElapsedTime = 0;
    void Start()
    {
        for (int I = 0; I < 4; I++)
        {
            Cloning();
        }
    }

     
    void Update()
    {
        ElapsedTime += Time.deltaTime;
    }

    void Cloning()
    {
        if (ElapsedTime > 0.2)
        {
            OgerClone = Instantiate(EnemyOger);
        }
        ElapsedTime = 0;    
    }
}
