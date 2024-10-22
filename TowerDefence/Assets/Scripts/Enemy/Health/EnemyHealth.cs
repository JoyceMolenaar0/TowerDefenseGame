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
    
    private int Health;
    void Start()
    {
        Health = MaxHealth;
        UpdateHealth();
    }

    
    void Update()
    {
        if (Health < 0)
        {
            Health = 0;
        }
    }

    private void UpdateHealth()
    {
        HealthSlider.value = Health;
        HealthText.text = "HP: " + Health;
    }

    public void TakeDamage(int TheDamage)
    {
        Health -= TheDamage;
        UpdateHealth();
    }
}
