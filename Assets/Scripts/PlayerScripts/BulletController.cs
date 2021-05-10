using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public static int bulletDamage = 1;
    public int bulletSpeed;

    private void OnTriggerEnter2D(Collider2D bulletCol)
    {
        if (bulletCol.tag == "Boss")
        {
            BossController.bossHP -= PlayerCharecterStats.playerOverAllDMG;
            //bossHP -= BulletController.bulletDamage;
            //print(enemyHP);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Translate(new Vector3(bulletSpeed, 0f, 0f) * Time.deltaTime);
    }
}
