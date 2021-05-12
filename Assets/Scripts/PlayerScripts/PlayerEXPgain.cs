using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEXPgain : MonoBehaviour
{
    public static float playerEXP;
    private float expForNextLVL;
    public static int playerLVL;
    public static int availableStatsPoints;


    void Start()
    {
        playerEXP = 0;
        playerLVL = 1;
        expForNextLVL = 50f;
        playerLVL = PlayerPrefs.GetInt("Player Level");
    }
    public void LevelUP()
    {

        if(playerEXP>expForNextLVL)
        {
            playerLVL++;
            PlayerPrefs.SetInt("Player Level", playerLVL);
            availableStatsPoints++;
            playerEXP = 0;
            expForNextLVL += expForNextLVL + 100f;
        }
    }

    void Update()
    {
        LevelUP();
        
    }
}
