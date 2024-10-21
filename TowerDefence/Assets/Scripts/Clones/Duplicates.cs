using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicates : MonoBehaviour
{
    [SerializeField] GameObject TheObjectThatNeedstoBeCloned;
    [SerializeField] int CloneAmount;
    [SerializeField] float TheWaitBeforeNewClone;

    private GameObject TheClone;
    private float ElapsedTime;
    private bool IsCloning = false;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        ElapsedTime += Time.time;
        if (ElapsedTime > 3 && !IsCloning)
        {
           ElapsedTime = 0f;
           StartCoroutine(Cloning());
        }
        
    }

    IEnumerator Cloning()
    {
        IsCloning = true;
        for (int i = 0; i < CloneAmount; i++)
        {
            TheClone = Instantiate(TheObjectThatNeedstoBeCloned);
            yield return new WaitForSeconds(TheWaitBeforeNewClone);
        }
        
    }
}
