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
    public GameObject bossBar;


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
            bossBar.SetActive(true);
            bossEnemyButton.SetActive(true);
            
        }
        else if(EnemyDeathController.enemydeathCount <=0 && !BossConrtoller.bossDead)
        {
            bossBar.SetActive(false);
        }
      
        
    }

}
