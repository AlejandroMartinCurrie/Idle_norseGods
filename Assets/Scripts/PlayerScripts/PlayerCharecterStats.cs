using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharecterStats : MonoBehaviour
{
    public static int playerOverAllHP;
    public static int playerOverAllDMG;
    public Gods currentSelectedGod;
    public static int playerBaseHealth;
    public static int playerBaseDamage = 1;
    public static string playerGodName;
    public static Sprite playerGodSprite;



    public static bool gameStarted;

    void Start()
    {

        if(StageController.stageCounter >0)
        {
            playerOverAllHP = PlayerPrefs.GetInt("CurrentHP");

        }
        else
        {
            playerOverAllHP = currentSelectedGod.godHealth + playerBaseHealth;
            playerOverAllDMG = currentSelectedGod.godDamage + playerBaseDamage;
            playerGodName = currentSelectedGod.godName;
            playerGodSprite = currentSelectedGod.godImage;

        }







    }


    // Update is called once per frame
    void Update()
    {
        
        print(playerOverAllHP);

    }
}
