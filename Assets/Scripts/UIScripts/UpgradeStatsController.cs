using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeStatsController : MonoBehaviour
{
    public int goldNeeded = 20;
    public Button addButton;
    public int nextLevelHealth;

    public static int currentMaxHealth;

    private void Start()
    {
        nextLevelHealth = 10;
        goldNeeded = 20;
        
    }


    public void playerHealthUpgradeUI()
    {
       
        if (GoldCurrancyController.currentCurrancy >= goldNeeded)
        {
            addButton.interactable = true;
            addButton.image.color = new Color(255,255,255,255);
            
            
        }
        else
        {
            addButton.interactable = false;
            addButton.image.color = new Color(255, 255, 255, 60);
        }

    }



    public void AddPointToHealth()
    {
        currentMaxHealth = PlayerCharecterStats.playerOverAllHP += nextLevelHealth;
        GoldCurrancyController.currentCurrancy -= goldNeeded;
        PlayerPrefs.SetInt("Gold", GoldCurrancyController.currentCurrancy);
        PlayerPrefs.SetInt("CurrentHP", currentMaxHealth);
        goldNeeded += 30;
    }

    private void Update()
    {
        playerHealthUpgradeUI();

        PlayerPrefs.SetInt("MaximumHP",PlayerCharecterStats.playerOverAllHP);
        print(PlayerPrefs.GetInt("MaximumHP"));
        
    }


}
