using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CallBossFight : MonoBehaviour
{
    public static bool bossIsAlive;
    public GameObject callBossButton;
    public GameObject bossToCreate;
    public Transform bossSpawnLocation;
    public GameObject enemySpawner;


    public void CreateBoss()
    {
        bossIsAlive = true;
        Instantiate(bossToCreate, bossSpawnLocation);
        

    }


    private void Update()
    {
        if(bossIsAlive)
        {
            print(bossIsAlive);
            callBossButton.SetActive(false);
            enemySpawner.SetActive(false);
            EnemyDeathController.isDead = true;
        }
    }



}
