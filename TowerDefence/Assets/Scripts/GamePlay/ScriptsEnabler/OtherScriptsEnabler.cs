using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherScriptsEnabler : MonoBehaviour
{
    [SerializeField] GameObject BulletScript;

    private float ElapsedTime = 0f;
    void Start()
    {
        BulletScript.SetActive(false);
    }

   
    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 15)
        {
            BulletScript.SetActive(true);
        }
    }
}
