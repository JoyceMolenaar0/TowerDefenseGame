using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CoinsText;
    private int Coins;
    void Start()
    {
        
    }

   
    void Update()
    {
        CoinsText.text = "Coins: " + Coins;
    }

    void UpdateText()
    {
        CoinsText.text = "Coins: " + Coins;
    }

    void AddScore(int AddingScore)
    {
        Coins += AddingScore;
    }

    void MinusScore(int DecreaseScore)
    {
        Coins -= DecreaseScore;
    }
}
