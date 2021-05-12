using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarControllerPlayer : MonoBehaviour
{
    public Image healthFill;
    public static float maxHP;
    public int currentHP;

    void Start()
    {
        maxHP = PlayerCharecterStats.playerOverAllHP;
    }
    void Update()
    {
        currentHP = PlayerCharecterStats.playerOverAllHP;
        healthFill.fillAmount = currentHP / maxHP;
        //print(maxHP);
    }
}
