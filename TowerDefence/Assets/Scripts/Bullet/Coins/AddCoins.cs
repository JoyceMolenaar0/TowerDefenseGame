using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoins : MonoBehaviour
{
    [SerializeField] int CoinsAddAmount;

    private CoinsUpdater CoinsUpdateScript;
    void Start()
    {
        GameObject CoinsUpdaterObject = GameObject.FindWithTag("CoinsUpdater");
        if (CoinsUpdaterObject != null)
        {
            CoinsUpdateScript = CoinsUpdaterObject.GetComponent<CoinsUpdater>();
        }
    }

    
    void Update()
    {
        
    }

    void AddCoinsToPlayer(int TheAmountOfCoins)
    {
        CoinsUpdateScript.PlayerCoins += TheAmountOfCoins;
        CoinsUpdateScript.UpdateCoins();
        Debug.Log("AddedCoins");
    }

    private void OnTriggerEnter(Collider Colliders)
    {
        if (Colliders.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy For Money");
            AddCoinsToPlayer(CoinsAddAmount);
            
        }
    }
}
