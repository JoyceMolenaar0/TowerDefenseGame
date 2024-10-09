using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Camera MainCamera;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.LookAt(MainCamera.transform.position);
    }
}
