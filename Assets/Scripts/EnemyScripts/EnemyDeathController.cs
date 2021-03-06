using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeathController : MonoBehaviour
{

    public static int enemyHP;
    public static bool isDead;
    public static int enemydeathCount;


    public void Start()
    {
        //isDead = false;
        GetEnemyInfo();
    }

    public void GetEnemyInfo()
    {
        enemyHP = StageController.currentEnemy.enemyHealth;
        GetComponentInChildren<SpriteRenderer>().sprite = StageController.currentEnemy.enemySprite;



        //enemyHP = GetComponentInChildren<ChangeEnemySprite>().newEnemi.enemyHealth;
    }

    private void OnTriggerEnter2D(Collider2D bulletCol)
    {
        if(bulletCol.CompareTag("Bullet"))
        {
            enemyHP -= PlayerCharecterStats.playerOverAllDMG;
            //enemyHP -= BulletController.bulletDamage;
            //print(enemyHP);
            Destroy(bulletCol.gameObject);
           

        }

    }
    private void EnemyDead()
    {
        if (enemyHP <= 0)
        {
            isDead = true;
            enemydeathCount++;
            PlayerEXPgain.playerEXP+=GetEnemyEXP.expGain;
            GoldCurrancyController.currentCurrancy += StageController.currentEnemy.goldDrop;
            PlayerPrefs.SetInt("Gold", GoldCurrancyController.currentCurrancy);
            //print(enemydeathCount);
            Destroy(gameObject);
        }
        else
        {
            isDead = false;
        }
    }
   

    private void Update()
    {
        
        EnemyDead();
        

    }


}
