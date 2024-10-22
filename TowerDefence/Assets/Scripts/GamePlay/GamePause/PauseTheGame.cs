using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTheGame : MonoBehaviour
{
    
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ContinueGame()
    {
        Time.timeScale = 1f;
    }
}
