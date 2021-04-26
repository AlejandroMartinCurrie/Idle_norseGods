using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject enemyCharacter;
    public Transform enemySpawner;
    

    public void CreateEnemy()
    {
        if(EnemyDeathController.isDead)
        {
            EnemyDeathController.isDead = false;
            Instantiate(enemyCharacter, enemySpawner);
            
        } 
    }

    private void Start()
    {
        Instantiate(enemyCharacter, enemySpawner);
       
    }

    void Update()
    {
        
        CreateEnemy();
    }
}
