using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharecterStats : MonoBehaviour
{
    public static int playerOverAllHP;
    public static int playerOverAllDMG;
    public Gods currentSelectedGod;
    public static int playerBaseHealth;
    public static int playerBaseDamage;
    public static string playerGodName;
    public static Sprite playerGodSprite;

    public static float maximumHealth;

    void Start()
    {

        

        UpgradeStatsController.healthUpgraded = PlayerPrefs.GetInt("SavedDataHealth");
        UpgradeStatsController.dmgUpgraded = PlayerPrefs.GetInt("SavedDataDMG");

        PlayerHealthStatsController();
        print(playerOverAllDMG);
        PlayerDamageStatsController();
        print(playerOverAllDMG);




        //playerOverAllDMG = currentSelectedGod.godDamage;

        //playerOverAllHP = currentSelectedGod.godHealth + playerBaseHealth;

        playerGodName = currentSelectedGod.godName;
        playerGodSprite = currentSelectedGod.godImage;

    }



    public void PlayerHealthStatsController()
    {
        if (UpgradeStatsController.healthUpgraded == 0)
        {
            playerBaseHealth = currentSelectedGod.godHealth;
            PlayerPrefs.SetInt("FullPlayerHealth", playerBaseHealth);

            playerOverAllHP = PlayerPrefs.GetInt("FullPlayerHealth");
            maximumHealth = playerOverAllHP;
        }
        else if (UpgradeStatsController.healthUpgraded >= 1)
        {
            playerOverAllHP = PlayerPrefs.GetInt("FullPlayerHealth");
            maximumHealth = playerOverAllHP;
        }
    }




    public void PlayerDamageStatsController()
    {
        if(UpgradeStatsController.dmgUpgraded == 0)
        {
            playerBaseDamage = currentSelectedGod.godDamage;
            PlayerPrefs.SetInt("FullPlayerDMG", playerBaseDamage);


            playerOverAllDMG = PlayerPrefs.GetInt("FullPlayerDMG");
        }
        else if (UpgradeStatsController.dmgUpgraded >=1)
        {
            playerOverAllDMG = PlayerPrefs.GetInt("FullPlayerDMG");
        }
    }




    // Update is called once per frame
    void Update()
    {
        
        //print("base hp " + playerBaseHealth);
        print("Over all dm " + playerOverAllDMG);

    }
}
