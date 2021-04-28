using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationController : MonoBehaviour
{
    public Animator spawnCircleController;



    public void SpawnCircle()
    {
        spawnCircleController.SetBool("Died", true);
       
    }


    public void StopAnimCircle()
    {
        spawnCircleController.SetBool("Died", false);
    }




    public void Start()
    {
        spawnCircleController.Play("SpawnAnimationCircle");
    }


    public void Update()
    {
        if(EnemyDeathController.isDead)
        {
            
            SpawnCircle();
        }
        else
        {
            StopAnimCircle();
        }
    }



}
