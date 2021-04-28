using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathController : MonoBehaviour
{

    public static int enemyHP;
    public static bool isDead;
    
    
    
    
    public void Start()
    {
        isDead = false;
        GetEnemyInfo();
    }



    public void GetEnemyInfo()
    {
        enemyHP = GetComponentInChildren<ChangeEnemySprite>().newEnemi.enemyHealth;
    }

    private void OnTriggerEnter2D(Collider2D bulletCol)
    {
        if(bulletCol.CompareTag("Bullet"))
        {
            enemyHP -= BulletController.bulletDamage;
            //print(enemyHP);
            Destroy(bulletCol.gameObject);  
        }
    }
    private void EnemyDead()
    {
        if (enemyHP <= 0)
        {
            isDead = true;
            print("Muerto");
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
