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
    public static bool callBoss;
    
    



    public void CreateEnemy()
    {
        if (!callBoss && EnemyDeathController.isDead)
        {
            Instantiate(enemyCharacter, enemySpawner);
            FindObjectOfType<EnemyDeathController>().GetEnemyInfo();
            EnemyDeathController.isDead = false;
        } 
    }


    public void CreateBoss()
    {
        Instantiate(bossCharacter, enemySpawner);
        callBoss = true;
        BossController.bossCombat = true;
        print(BossController.bossCombat);
        EnemyDeathController.enemyHP = 0;
        EnemyDeathController.enemydeathCount = 0;
        callBossButton.SetActive(false);
    }



    private void Start()    
    {
        callBoss = false;
        Instantiate(enemyCharacter, enemySpawner);
        BossController.bossDead = true;
    }

    void Update()
    {
        //if(!BossConrtoller.bossStageCleared)
        //{
            
        //}
        CreateEnemy();


    }
}
