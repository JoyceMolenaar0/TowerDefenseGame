using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TowerEnabler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] GameObject Tower1;
    [SerializeField] GameObject Tower2;
    [SerializeField] GameObject Tower3;
    
    private int Tower1Cost = 100;
    
    void Start()
    {
      
    }

    
    void Update()
    {
        
    }

    public void Tower1Enabler()
    {
        if (ScoreText.text == "Coins:" + Tower1Cost)
        {
            Tower1.SetActive(true);

        }

    }
    public void Tower2Enabler()
    {
        
    }
    public void Tower3Enabler()
    {
        
    }
}
