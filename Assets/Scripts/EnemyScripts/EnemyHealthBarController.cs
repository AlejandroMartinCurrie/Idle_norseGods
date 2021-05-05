using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealthBarController : MonoBehaviour
{
    public Image fill;
    public float fullHP;
    public int currentHP;
    

    private void Start()
    {
        fullHP = StageController.currentEnemy.enemyHealth;
        
    }

    public void Update()
    {
        currentHP = EnemyDeathController.enemyHP;

        fill.fillAmount = currentHP/fullHP;

        //print(currentHP);
        //print(fullHP);
    }
}
