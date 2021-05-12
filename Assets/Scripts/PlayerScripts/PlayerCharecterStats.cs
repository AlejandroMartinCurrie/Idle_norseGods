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

    void Start()
    {

        playerBaseHealth = 10;
        playerBaseDamage = 1;

        playerOverAllHP = currentSelectedGod.godHealth + playerBaseHealth;
        playerOverAllDMG = currentSelectedGod.godDamage + playerBaseDamage;
        HealthBarControllerPlayer.maxHP = playerOverAllHP;
        playerGodName = currentSelectedGod.godName;
        playerGodSprite = currentSelectedGod.godImage;
        //PlayerPrefs.SetString("Gods Name", playerGodName);

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
