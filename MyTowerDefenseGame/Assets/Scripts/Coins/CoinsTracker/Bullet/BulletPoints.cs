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

    private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.gameObject.tag == "Enemy")
        {
            CoinsUpdaterScript.AddScore(1);
            CoinsUpdaterScript.UpdateScore();   
        }
    }
}
