using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] Slider HealthSlider;
    [SerializeField] TextMeshProUGUI HealthScore;

    int Health;
    int MaxHealth = 100;
    int MinHealth = 0;

    void Start()
    {
        Health = MaxHealth;
        UpdateHP();  
    }

    void Update()
    {
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        else if (Health < MinHealth)
        {
            Health = MinHealth;
        }

        UpdateHP();
    }

    public void UpdateHP()
    {
        HealthSlider.value = Health;
        HealthScore.text = "HP: " + Health;
        Debug.Log("Updated the HP");
    }
    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        UpdateHP();
        Debug.Log("Health: " + Health);
    }
}