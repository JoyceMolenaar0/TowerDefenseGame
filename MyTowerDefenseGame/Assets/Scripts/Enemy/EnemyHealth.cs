using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider HealthSlider;
    public float MaxHealth = 100f;
    public float Health;
    void Start()
    {
        Health = MaxHealth;
    }

   
    void Update()
    {
       HealthSlider.value = Health;
    }
}
