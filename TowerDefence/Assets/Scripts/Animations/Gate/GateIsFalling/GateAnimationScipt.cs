using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GateAnimationScipt : MonoBehaviour
{
    [SerializeField] Animator GateFallAnimator;
    [SerializeField] Transform Enemy;
    [SerializeField] GameObject DoorPoint;

    private float ElapsedTime = 0;
    void Start()
    {
        GateIsStanding();
    }

    
    void Update()
    {
        Debug.Log("Elapsed Time = " + ElapsedTime);
        if (Vector3.Distance(Enemy.transform.position, DoorPoint.transform.position) < 0.2f)
        {
            Debug.Log("EnemyReachedMe");
            GateShake();
            if (ElapsedTime > 15)
            {
                GateFalling();
            }
        }
        
    }

    private void GateShake()
    {
        GateFallAnimator.SetBool("GateIsFalling", false);
        GateFallAnimator.SetBool("GateIsShaking", true);
        GateFallAnimator.SetBool("GateIsStanding", false);
    }

    private void GateFalling()
    {
        GateFallAnimator.SetBool("GateIsFalling", true);
        GateFallAnimator.SetBool("GateIsShaking", false);
        GateFallAnimator.SetBool("GateIsStanding", false);
    }

    private void GateIsStanding()
    {
        GateFallAnimator.SetBool("GateIsFalling", false);
        GateFallAnimator.SetBool("GateIsShaking", false);
        GateFallAnimator.SetBool("GateIsStanding", true);
    }
}
