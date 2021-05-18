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
        print(maxHP);
        //maxHP = PlayerPrefs.GetFloat("MaximumHP");
    }
    void Update()
    {
        currentHP = PlayerPrefs.GetInt("CurrentHP");
        healthFill.fillAmount = currentHP / 100;
        //print(maxHP);
    }
}
