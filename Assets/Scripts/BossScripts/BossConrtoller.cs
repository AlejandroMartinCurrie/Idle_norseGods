using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossConrtoller : MonoBehaviour
{
    public static int bossHP;
    public static bool bossDead;
    public static bool bossStageCleared;
    

    public void Start()
    {
        GetBossInfo();
        bossStageCleared = false;
    }

    public void GetBossInfo()
    {
        bossHP = StageController.currentBoss.bossHealth;
        bossDead = StageController.currentBoss.bossCompleted;
        GetComponentInChildren<SpriteRenderer>().sprite = StageController.currentBoss.bossSprite;
        //bossHP = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossHealth;
        //bossDead = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossCompleted;
    }

    private void OnTriggerEnter2D(Collider2D bulletCol)
    {
        if (bulletCol.CompareTag("Bullet"))
        {
            bossHP -= BulletController.bulletDamage;
            //print(enemyHP);
            Destroy(bulletCol.gameObject);
        }
    }

    public void BossDeathController()
    {
        if(bossHP<=0)
        {
            PlayerEXPgain.playerEXP += StageController.currentBoss.bossExp;
            StageController.stageCounter++;
            PlayerPrefs.SetInt("Stage", StageController.stageCounter); 
            bossStageCleared = true;
            bossDead = true;
            EnemySpawnController.callBoss = false;
            Destroy(gameObject);
        }
        else
        {
            bossDead = false;
        }
    }



    public void Update()
    {
        BossDeathController();
    }

}
