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

    void Start()
    {

        playerBaseHealth = 10;
        playerBaseDamage = 1;

        playerOverAllHP = currentSelectedGod.godHealth + playerBaseHealth;
        playerOverAllDMG = currentSelectedGod.godDamage + playerBaseDamage;
        HealthBarControllerPlayer.maxHP = playerOverAllHP;

        //print(playerOverAllHP);
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
