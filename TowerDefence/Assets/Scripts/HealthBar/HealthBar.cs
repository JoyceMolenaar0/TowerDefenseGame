using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider HealthSlider;
    [SerializeField] TextMeshProUGUI HealthText;

    private int Damage = 20;
    private int Health;
    private int MaxHealth = 100;
    void Start()
    {
        Health = MaxHealth;
    }

   
    void Update()
    {
        UpdateHealthBar();

    }

    void UpdateHealthBar()
    {
        if (Health < 0)
        {
            Health = 0;
        }

        HealthSlider.value = Health;
        HealthText.text = "HP: " + Health;
    }


}
