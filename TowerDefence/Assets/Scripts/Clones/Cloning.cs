using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cloning : MonoBehaviour
{
    [SerializeField] GameObject EnemyOger;
    private GameObject OgerClone;
    
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Duplication();
        }
    }

    
    void Update()
    {
        
    }

    void Duplication()
    {
        OgerClone = Instantiate(EnemyOger);
    }
}
