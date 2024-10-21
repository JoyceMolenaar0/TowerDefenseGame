using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRemoval : MonoBehaviour
{
    [SerializeField] GameObject Gate;

    private float ElapsedTime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > 15)
        {
            Destroy(Gate);
            return;
        }
    }
}
