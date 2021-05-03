using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossConrtoller : MonoBehaviour
{
    public static int bossHP;
    public static bool bossDead;
    public void Start()
    {
        GetBossInfo();
    }

    public void GetBossInfo()
    {
        bossHP = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossHealth;
        bossDead = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossCompleted;
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
            bossDead = true;
            PlayerEXPgain.playerEXP += GetBossExp.bossExpGain; 
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
