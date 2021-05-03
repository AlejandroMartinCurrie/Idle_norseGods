using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject enemyCharacter;
    public GameObject bossCharacter;
    public GameObject spawner;
    public GameObject callBossButton;
    public Transform enemySpawner;
    public static bool callBoss = false;
    



    public void CreateEnemy()
    {
        if (!callBoss && EnemyDeathController.isDead)
        {
            Instantiate(enemyCharacter, enemySpawner);
            FindObjectOfType<EnemyDeathController>().GetEnemyInfo();
            EnemyDeathController.isDead = false;
        } 
    }


    public void InvokeBoss()
    {
        
        EnemyDeathController.enemyHP = 0;
        callBoss = true;
        EnemyDeathController.enemydeathCount = 0;
        Instantiate(bossCharacter, enemySpawner);
        callBossButton.SetActive(false);
    }



    private void Start()    
    {
        Instantiate(enemyCharacter, enemySpawner);
        BossConrtoller.bossDead = true;
       
    }

    void Update()
    {
        if(BossConrtoller.bossDead)
        {
            CreateEnemy();
            callBoss = false;
        }

        
    }
}
