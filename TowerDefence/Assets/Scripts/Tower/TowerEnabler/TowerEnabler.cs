using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerEnabler : MonoBehaviour
{
    [SerializeField] GameObject[] Towers;
    [SerializeField] TextMeshProUGUI Coins;
    [SerializeField] int[] TowerCost;
    private int CoinsAmount;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void BuyTower1()
    {
        if(CoinsAmount == TowerCost[1] || CoinsAmount > TowerCost[1])
        {
            Towers[1].SetActive(true);
        }
        
    }

    void CoinsUpdater()
    {
        Coins.text = "Coins: " + CoinsAmount;
    }


}
