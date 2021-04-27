using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationController : MonoBehaviour
{
    public Animator spawnCircleController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyDeathController.isDead)
        {  
            spawnCircleController.Play("SpawnAnimationCircle");
        }
        else
        {
           
        }
     
    }
}
