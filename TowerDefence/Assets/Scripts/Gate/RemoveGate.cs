using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGate : MonoBehaviour
{
    [SerializeField] GameObject Gate;

    private float ElapsedTime;
    void Start()
    {
        
    }

    
    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 15)
        {
            Gate.SetActive(false);
        }
    }
}
