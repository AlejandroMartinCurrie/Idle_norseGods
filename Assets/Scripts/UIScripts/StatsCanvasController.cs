using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsCanvasController : MonoBehaviour
{
    public GameObject playerStats;
    public bool StatsCanvasActive;
    public TMP_Text currentGodsName;
    public Image currntGodsImage;

    public TMP_Text playerHpStats;
    public TMP_Text playerAttkStats;
    public TMP_Text healthGoldNeeded;
    public TMP_Text dmgGoldNeeded;


    public void ActivatePlayerStats()
    {
        if(StatsCanvasActive)
        {
            playerStats.SetActive(false);
            StatsCanvasActive = false;
        }
        else
        {
            playerStats.SetActive(true);
            StatsCanvasActive = true;
        }  
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        currentGodsName.text = PlayerCharecterStats.playerGodName;
        currntGodsImage.sprite = PlayerCharecterStats.playerGodSprite;

        playerHpStats.text = PlayerCharecterStats.maximumHealth.ToString();
        playerAttkStats.text = PlayerCharecterStats.playerOverAllDMG.ToString();
        healthGoldNeeded.text = UpgradeStatsController.healthGoldNeeded.ToString() + " g";
        dmgGoldNeeded.text = UpgradeStatsController.dmgGoldNeeded.ToString() + " g";







    }
}
