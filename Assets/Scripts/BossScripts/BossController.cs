using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{
    public static int bossHP;
    public static bool bossDead;
    public static bool bossStageCleared;
    public static bool bossCombat;
    public static int bossDamage;
    

    public void Start()
    {
        GetBossInfo();
        bossStageCleared = false;
    }

    public void GetBossInfo()
    {
        bossHP = StageController.currentBoss.bossHealth;
        bossDead = StageController.currentBoss.bossCompleted;
        bossDamage = StageController.currentBoss.bossDMG;
        GetComponentInChildren<SpriteRenderer>().sprite = StageController.currentBoss.bossSprite;
        //bossHP = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossHealth;
        //bossDead = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossCompleted;
    }

   

    public void BossDeathController()
    {
        if(bossHP<=0)
        {
            PlayerEXPgain.playerEXP += StageController.currentBoss.bossExp;
            StageController.stageCounter++;
            PlayerPrefs.SetInt("Stage", StageController.stageCounter);
            bossCombat = false;
            bossStageCleared = true;
            bossDead = true;
            GoldCurrancyController.currentCurrancy += StageController.currentBoss.bossGoldDrop;
            PlayerPrefs.SetInt("Gold", GoldCurrancyController.currentCurrancy);
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
