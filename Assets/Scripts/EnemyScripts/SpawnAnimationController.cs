using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationController : MonoBehaviour
{
    public Animator spawnCircleController;

    public void Start()
    {
        spawnCircleController.Play("SpawnAnimation");
    }


    public void Update()
    {
        if(EnemyDeathController.isDead)
        {
            
        }

    }



}
