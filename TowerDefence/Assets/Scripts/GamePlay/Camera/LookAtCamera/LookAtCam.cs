using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    [SerializeField] Transform Cameras;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.LookAt(Cameras);
    }
}
