using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldCurrancyController : MonoBehaviour
{
    public TMP_Text coinCurrancy;
    public static int currentCurrancy;
    public static ParticleSystem coinsFall;


    public void GetEnemyGold()
    {
       
        currentCurrancy += StageController.currentEnemy.goldDrop;
        
        PlayerPrefs.SetInt("Gold", currentCurrancy);
        coinCurrancy.text = currentCurrancy.ToString();
    }


    public void GetBossGold()
    {
        currentCurrancy += StageController.currentBoss.bossGoldDrop;
       
        PlayerPrefs.SetInt("Gold", currentCurrancy);
        coinCurrancy.text = currentCurrancy.ToString();
    }

    void Start()
    {
        currentCurrancy = PlayerPrefs.GetInt("Gold");
        coinCurrancy.text = currentCurrancy.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinCurrancy.text = currentCurrancy.ToString();

    }
}
