using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeginMove : MonoBehaviour
{
    [SerializeField] Animator EnemyAnimator;
    void Start()
    {
        EnemyAnimator.SetBool("EnemyKick", true);
    }

   
    void Update()
    {
        
    }
}
