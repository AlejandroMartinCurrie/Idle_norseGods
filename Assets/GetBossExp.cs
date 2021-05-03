using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBossExp : MonoBehaviour
{
    public static float bossExpGain;
    void Start()
    {
        bossExpGain = GetComponentInChildren<ChangeBossSpriteController>().newBoss.bossExp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
