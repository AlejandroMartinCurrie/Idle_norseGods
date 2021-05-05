using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCountDownController : MonoBehaviour
{
    public Image fill;
    public static bool bossBarFull;
    public GameObject bossEnemyButton;
    public GameObject bossBar;


    public void Start()
    {
        bossBarFull = false;
        
    }

    public void Update()
    {
        fill.fillAmount = EnemyDeathController.enemydeathCount/StageController.killsNeededForBoss;

        if(EnemyDeathController.enemydeathCount >= StageController.killsNeededForBoss)
        {
            bossBarFull = true;
            bossBar.SetActive(false);
            bossEnemyButton.SetActive(true);
            
        }

        
    }

}
