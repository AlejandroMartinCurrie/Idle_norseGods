using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEXPgain : MonoBehaviour
{
    private float playerEXP;
    private float expForNextLVL;
    public static int playerLVL;
    public static int availableStatsPoints;


    void Start()
    {
        playerEXP = 0;
        playerLVL = 1;
        expForNextLVL = 100f;


    }
    public void LevelUP()
    {
        if(playerEXP>=expForNextLVL)
        {
            playerEXP = 0;
            expForNextLVL += expForNextLVL + 100f;
            playerLVL++;
            availableStatsPoints++;
        }
    }


    void Update()
    {
        if (EnemyDeathController.isDead)
        {
            playerEXP += GetEnemyEXP.expGain;
        }
        
        LevelUP();
        print(playerLVL);
    }
}
