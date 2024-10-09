using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] Slider HealthSlider;
    [SerializeField] TextMeshProUGUI HPText;

    [SerializeField] int MaxHealth = 100;
    [SerializeField] int Health;
    void Start()
    {
        Health = MaxHealth;
    }

    
    void Update()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        HealthSlider.value = Health;
        HPText.text = "HP: " + Health;
    }

    public void Damage(int TheDamage)
    {
        Health -= TheDamage;
        UpdateHealth();
    }

    public void Healing(int Heal)
    {
        Health += Heal;
        UpdateHealth();
    }
}
