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

        playerHpStats.text = PlayerCharecterStats.playerOverAllHP.ToString();
        playerAttkStats.text = PlayerCharecterStats.playerOverAllDMG.ToString();

    }
}
