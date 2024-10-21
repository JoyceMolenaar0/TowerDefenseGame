using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRemoval : MonoBehaviour
{
    [SerializeField] GameObject Gate;

    private float ElapsedTime = 0;
    void Start()
    {
<<<<<<< HEAD:TowerDefence/Assets/Scripts/GamePlay/ScriptsEnabler/OtherScriptsEnabler.cs
        BulletScript.SetActive(false);
=======
        
>>>>>>> parent of d5390c9 (CommitChange):TowerDefence/Assets/Scripts/Animations/Gate/GateIsFalling/GateRemoval.cs
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > 15)
        {
            Destroy(Gate);
            return;
        }
    }
}
