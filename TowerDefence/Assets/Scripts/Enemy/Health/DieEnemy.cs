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
        Debug.Log("Current Health: " + HealthSlider.value);

        if (HealthSlider.value <= 0)
        {
            Destroy(gameObject);
            return;
        }
    }
}
