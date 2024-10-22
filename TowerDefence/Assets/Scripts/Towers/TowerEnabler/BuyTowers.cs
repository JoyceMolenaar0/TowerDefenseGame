using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyTowers : MonoBehaviour
{
    [SerializeField] GameObject[] Towers;
    [SerializeField] GameObject[] BulletCloneScript;
    [SerializeField] int[] TowerCost;

    private CoinsUpdater CoinsUpdateScript;

    void Start()
    {
        GameObject CoinsUpdaterObject = GameObject.FindWithTag("CoinsUpdater");
        if (CoinsUpdaterObject != null)
        {
            CoinsUpdateScript = CoinsUpdaterObject.GetComponent<CoinsUpdater>();
        }

       for (int i = 0; i < Towers.Length; i++)
        {
            Towers[i].SetActive(false);
            BulletCloneScript[i].SetActive(false);
        }

         
    }

   
    void Update()
    {
        
    }

    public void BuyTheTowers(int TowerNumber)
    {
        if (TowerNumber >= 0 && TowerNumber < Towers.Length)
        {
            if (CoinsUpdateScript.PlayerCoins >= TowerCost[TowerNumber])
            {
                Towers[TowerNumber].SetActive(true);
                BulletCloneScript[TowerNumber].SetActive(true);
                CoinsUpdateScript.PlayerCoins -= TowerCost[TowerNumber];
                CoinsUpdateScript.UpdateCoins();
            }
        }
    }

    
}
