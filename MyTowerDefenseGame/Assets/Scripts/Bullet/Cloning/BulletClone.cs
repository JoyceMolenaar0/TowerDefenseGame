using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletClone : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    private GameObject CloneBullet;

    private float ElapsedTime;
    void Start()
    {
        
    }

   
    void Update()
    {

        GameObject Enemy = GameObject.FindWithTag("Enemy");
        ElapsedTime += Time.deltaTime;
        if (Enemy != null)
        {
            if (ElapsedTime > 3)
            {
                StartCoroutine(CloningBullet(3));
                ElapsedTime = 0;
            }
        }
        else
        {
            return;
        }
    }

    IEnumerator CloningBullet(int Clones)
    {
        for (int i = 0; i < Clones; i++)
        {
            CloneBullet = Instantiate(Bullet);
            yield return new WaitForSeconds(0.2f);
            
        }
    }
}
