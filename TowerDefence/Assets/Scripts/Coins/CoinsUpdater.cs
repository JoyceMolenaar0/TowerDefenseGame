using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsUpdater : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CoinsPlayerText;

    public int PlayerCoins;

    void Start()
    {
        PlayerCoins = 75;
        UpdateCoins();
    }
    void Update()
    {
        UpdateCoins();    
    }


    public void UpdateCoins()
    {
        CoinsPlayerText.text = "Coins: " + PlayerCoins;
    }
}
