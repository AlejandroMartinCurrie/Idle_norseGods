using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject enemyCharacter;
    public Transform enemySpawner;
    
    public void CreateEnemy()
    {
        if (EnemyDeathController.isDead && !CallBossFight.bossIsAlive)
        {
            print(CallBossFight.bossIsAlive);
            Instantiate(enemyCharacter, enemySpawner);
            FindObjectOfType<EnemyDeathController>().GetEnemyInfo();
            EnemyDeathController.isDead = false;
        }
        
            
        
    }

    private void Start()
    {
        Instantiate(enemyCharacter, enemySpawner);
       
    }

    void Update()
    {

        //CreateEnemy();
    }
}
