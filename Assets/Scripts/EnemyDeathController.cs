using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathController : MonoBehaviour
{
   [SerializeField] int enemyHP;
    public static bool isDead;
    


    private void OnTriggerEnter2D(Collider2D bulletCol)
    {
        if(bulletCol.CompareTag("Bullet"))
        {
            enemyHP -= BulletController.bulletDamage;
            print(enemyHP);
            Destroy(bulletCol.gameObject);  
        }
    }
    private void EnemyDead()
    {
        if (enemyHP <= 0)
        {
            isDead = true;
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
