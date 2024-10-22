using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyBeginMove : MonoBehaviour
{
    [SerializeField] Animator EnemyAnimator;
    [SerializeField] GameObject DoorPoint;
    
    void Start()
    {
        EnemyAnimator.SetBool("IsWalking", true);
    }

   
    void Update()
    {
        if (Vector3.Distance(transform.position, DoorPoint.transform.position) < 0.2f)
        {
            IsKicking();
        }
        else
        {
            IsWalking();
        }
    }

    void IsWalking()
    {
        EnemyAnimator.SetBool("IsWalking", true);
        EnemyAnimator.SetBool("IsDying", false);
        EnemyAnimator.SetBool("IsKicking", false);
    }

    void IsDying()
    {
        EnemyAnimator.SetBool("IsDying", true);
        EnemyAnimator.SetBool("IsWalking", false);
        EnemyAnimator.SetBool("IsKicking", false);
    }

    void IsKicking()
    {
        EnemyAnimator.SetBool("IsKicking", true);
        EnemyAnimator.SetBool("IsWalking", false);
        EnemyAnimator.SetBool("IsDying", false);
    }
}
