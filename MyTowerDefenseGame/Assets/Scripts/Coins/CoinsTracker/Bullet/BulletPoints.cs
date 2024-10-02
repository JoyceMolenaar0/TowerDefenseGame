using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoints : MonoBehaviour
{
     CoinsUpdater CoinsUpdaterScript;
    
    void Start()
    {
        CoinsUpdaterScript = FindObjectOfType<CoinsUpdater>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider CollBullet)
    {
        if (CollBullet.gameObject.tag == "Enemy")
        {
            Debug.Log("lalakoes");
            CoinsUpdaterScript.AddScore(25);
            CoinsUpdaterScript.UpdateScore();   
        }
    }
}
