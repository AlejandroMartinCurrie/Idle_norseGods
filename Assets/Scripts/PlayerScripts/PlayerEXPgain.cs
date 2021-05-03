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
    }
    public void LevelUP()
    {

        if(playerEXP>expForNextLVL)
        {
            playerLVL++;
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
