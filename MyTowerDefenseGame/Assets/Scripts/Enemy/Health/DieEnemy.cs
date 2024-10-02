using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieEnemy : MonoBehaviour
{
    [SerializeField] Slider HealthSlider;

    void Start()
    {

    }


    void Update()
    {
        if (HealthSlider.value < 1)
        {
            EnemyDies();
        }
    }

    void EnemyDies()
    {
        Destroy(gameObject);
        return;
    }
}
