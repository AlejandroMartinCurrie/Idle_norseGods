using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCountDownController : MonoBehaviour
{
    public Image fill;
    public static bool bossBarFull;
    public float killsForBoss;
    public GameObject bossEnemyButton;


    public void Start()
    {
        bossBarFull = false;
        killsForBoss = 10f;
        
    }


    public void Update()
    {
        fill.fillAmount = EnemyDeathController.enemydeathCount/killsForBoss;

        if(EnemyDeathController.enemydeathCount >= killsForBoss)
        {
            bossBarFull = true;
            gameObject.SetActive(false);
            bossEnemyButton.SetActive(true);
            EnemyDeathController.enemydeathCount = 0;
        }
        else
        {
            gameObject.SetActive(true);
        }
        
    }

}
