using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarControllerPlayer : MonoBehaviour
{
    public Image healthFill;
    public float maxHP;
    public static int currentHP;

    void Start()
    {
        maxHP = PlayerCharecterStats.playerOverAllHP;
        //print(maxHP);
       
    }
    void Update()
    {
        currentHP = PlayerCharecterStats.playerOverAllHP;
        maxHP = PlayerCharecterStats.maximumHealth;
        healthFill.fillAmount = currentHP / maxHP;
        //print(maxHP);
    }
}
