using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeStatsController : MonoBehaviour
{
    public static int healthGoldNeeded;
    public static int dmgGoldNeeded;

    public Button addButton;
    public Button dmgAddbutton;
    public int nextLevelHealth;

    public static int currentMaxHealth;

    public static int healthUpgraded;
    public static int dmgUpgraded;


    private void Start()
    {


        if (healthUpgraded==0)
        {
            healthGoldNeeded = 20;
        }
        else
        {
            healthGoldNeeded = PlayerPrefs.GetInt("HealthGoldNeeded");
        }


        if(dmgUpgraded ==0)
        {
            dmgGoldNeeded = 20;
        }
        else
        {
            dmgGoldNeeded = PlayerPrefs.GetInt("DMgGoldNeeded");
        }

        
    }

    public void PlayerHealthUpgradeUI()
    {

        if (GoldCurrancyController.currentCurrancy >= healthGoldNeeded)
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



    public void PlayerDMGUpgradeUI()
    {
        if (GoldCurrancyController.currentCurrancy >= dmgGoldNeeded)
        {
            dmgAddbutton.interactable = true;
            dmgAddbutton.image.color = new Color(255, 255, 255, 255);
        }
        else
        {
            dmgAddbutton.interactable = false;
            dmgAddbutton.image.color = new Color(255, 255, 255, 60);
        }
    }






   public void UpgradeHealthStats()
    {

        GoldCurrancyController.currentCurrancy -= healthGoldNeeded;
        PlayerCharecterStats.maximumHealth += 10;
        PlayerCharecterStats.playerOverAllHP = (int)PlayerCharecterStats.maximumHealth;
        PlayerPrefs.SetInt("FullPlayerHealth", PlayerCharecterStats.playerOverAllHP);
        healthUpgraded++;
        PlayerPrefs.SetInt("SavedDataHealth", healthUpgraded);
        healthGoldNeeded += healthGoldNeeded + 20;
    }




    public void UpgradeDamageStats()
    {
        GoldCurrancyController.currentCurrancy -= dmgGoldNeeded;
        PlayerCharecterStats.playerOverAllDMG += 1;
        PlayerPrefs.SetInt("FullPlayerDMG", PlayerCharecterStats.playerOverAllDMG);
        dmgUpgraded++;
        PlayerPrefs.SetInt("SavedDataDMG", dmgUpgraded);
        dmgGoldNeeded += dmgGoldNeeded + 20;
    }





    private void Update()
    {
        PlayerHealthUpgradeUI();
        PlayerDMGUpgradeUI();
        PlayerPrefs.SetInt("HealthGoldNeeded", healthGoldNeeded);
        PlayerPrefs.SetInt("DMgGoldNeeded", dmgGoldNeeded);
        //print(healthGoldNeeded);
    }
}
