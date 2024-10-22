using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveAnimations : MonoBehaviour
{
    [SerializeField] Animator EnemyAnimator;
    [SerializeField] GameObject DoorPoint;

    private int CurrentPos;
    void Start()
    {
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, DoorPoint.transform.position) < 0.2)
        {
            KickAnimation();
        }
        else
        {
            WalkAnimation();
        }

        
    }

    void WalkAnimation()
    {
        EnemyAnimator.SetBool("IsWalking", true);
        EnemyAnimator.SetBool("IsKicking", false);
        EnemyAnimator.SetBool("IsDying", false);
    }

    void KickAnimation()
    {
        EnemyAnimator.SetBool("IsWalking", false);
        EnemyAnimator.SetBool("IsKicking", true);
        EnemyAnimator.SetBool("IsDying", false);
    }

    void DieAnimation()
    {
        EnemyAnimator.SetBool("IsWalking", false);
        EnemyAnimator.SetBool("IsKicking", false);
        EnemyAnimator.SetBool("IsDying", true);
    }
}
