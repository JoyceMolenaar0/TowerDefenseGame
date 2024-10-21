using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider HealthSlider;
    [SerializeField] TextMeshProUGUI HealthText;
    [SerializeField] int MaxHealth;
    public int Health;
    
    void Start()
    {
        Health = MaxHealth;
        UpdateHealthBar();
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
