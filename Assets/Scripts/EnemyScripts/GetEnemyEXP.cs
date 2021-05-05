using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemyEXP : MonoBehaviour
{
    public static float expGain;
    void Start()
    {
        expGain = StageController.currentEnemy.enemyExpDrop;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
