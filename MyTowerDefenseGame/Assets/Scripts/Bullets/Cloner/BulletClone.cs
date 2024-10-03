using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletClone : MonoBehaviour
{
    private float ElapsedTime = 0;
    private bool CoroutineIsPlaying = false;
    private GameObject NewBullet;

    [SerializeField] GameObject Bullet;

    private void Start()
    {
        
    }

    private void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 3 && !CoroutineIsPlaying)
        {
           StartCoroutine(CloneBullet(3));
        }
    }

    IEnumerator CloneBullet(int Bullets)
    {
        for (int i = 0; i < Bullets; i++)
        {
            NewBullet = Instantiate(Bullet);
            CoroutineIsPlaying = true;
            yield return new WaitForSeconds(0.2f);
        }
        ElapsedTime = 0f;
        CoroutineIsPlaying= false;
    }


}