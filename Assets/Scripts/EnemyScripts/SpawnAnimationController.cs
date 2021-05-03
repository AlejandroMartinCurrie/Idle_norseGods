using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationController : MonoBehaviour
{
    public Animator spawnCircleController;
    EnemySpawnController enemySpawnController;

    public void Start()
    {
        spawnCircleController.Play("SpawnAnimation");
        enemySpawnController = FindObjectOfType<EnemySpawnController>();
    }


    public void Update()
    {
        if(EnemyDeathController.isDead && !CallBossFight.bossIsAlive)
        {
            spawnCircleController.SetTrigger("StarSpawn");
        }
        else
        {
            spawnCircleController.ResetTrigger("StarSpawn");
        }

    }


    public void CallSpawnFunction()
    {
        enemySpawnController.CreateEnemy();
    }




}
