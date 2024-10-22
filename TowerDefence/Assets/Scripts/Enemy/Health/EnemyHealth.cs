using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] Slider HealthSlider;
    [SerializeField] TextMeshProUGUI HealthText;
    [SerializeField] int MaxHealth;
    [SerializeField] int Damage;
    public int Health;
    void Start()
    {
        Health = MaxHealth;
        UpdateHealth();
    }

    
    void Update()
    {
        
    }

    void UpdateHealth()
    {
        HealthSlider.value = Health;
        HealthText.text = "HP: " + Health;
    }

    void TakeDamage(int TheDamage)
    {
        Health -= TheDamage;
    }
}
