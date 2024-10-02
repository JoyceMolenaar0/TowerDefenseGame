using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Transform CameraTransform;
    public Slider HealthSlider;
    public float MaxHealth = 100f;
    public float Health;
    
    void Start()
    {
        Health = MaxHealth;

        if (CameraTransform == null)
        {
            CameraTransform = Camera.main.transform;
        }
    }

   
    void Update()
    {
       if (HealthSlider.value != Health)
        {
            HealthSlider.value = Health;
        }

       HealthSlider.transform.LookAt(CameraTransform);
       
       
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        
    }

    void GiveHealth(float Healing)
    {
        Health += Healing;
    }

}
