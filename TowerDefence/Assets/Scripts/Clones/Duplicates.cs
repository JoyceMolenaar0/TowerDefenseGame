using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicates : MonoBehaviour
{
    [SerializeField] GameObject TheObjectThatNeedstoBeCloned;
    [SerializeField] float MaxCloneAmount;
    [SerializeField] float TheCloneAmountPerWave;
    [SerializeField] float TheWaitBeforeNewClone;
    [SerializeField] float TheIntervalTime;

    private GameObject TheClone;

    private bool IsCloning = false;
    private float ElapsedTime;
    private float CloneCount;
    
    void Start()
    {
        IsCloning = false;
    }

    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > TheIntervalTime && CloneCount < MaxCloneAmount && IsCloning == false)
        {
            StartCoroutine(MakeClones());
            IsCloning = true;
        }
    }

    IEnumerator MakeClones()
    {
        for (int i = 0; i < TheCloneAmountPerWave; i++)
        {
            TheClone = Instantiate(TheObjectThatNeedstoBeCloned);
            yield return new WaitForSeconds(TheWaitBeforeNewClone);
            ElapsedTime = 0;
            CloneCount++;
            IsCloning = false;
        }
    }
}
