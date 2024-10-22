using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCam : MonoBehaviour
{
    [SerializeField] Camera[] Cameras;
    void Start()
    {
        SwitchCameras(0);
    }

     
    void Update()
    {
        
    }
    
    public void SwitchCameras(int CameraCount)
    {
        for (int i = 0; i < Cameras.Length; i++)
        {
            Cameras[i].enabled = false;
        }

        if (CameraCount >= 0 && CameraCount < Cameras.Length)
        {
            Cameras[CameraCount].enabled = true;
        }
    }
}
