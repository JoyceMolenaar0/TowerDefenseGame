using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class CoinsUpdater : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject Bullet;

    private int ScoreCount = 0;
    void Start()
    {

    }

    
    void Update()
    {
        UpdateScore();  
    }

    public void AddScore(int Score)
    {
        ScoreCount += Score;
        UpdateScore();
    }

    void RemoveScore(int Score)
    {
        ScoreCount -= Score;
        UpdateScore();
    }

    public void UpdateScore()
    {
        ScoreText.text = "Coins:" + ScoreCount;
    }
}
