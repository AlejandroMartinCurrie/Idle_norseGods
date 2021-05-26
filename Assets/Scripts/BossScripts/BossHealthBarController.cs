using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBarController : MonoBehaviour
{
    public Image bossHealthFill;
    public float bossMaxHP;
    public static int bossCurrentHP;
    


    void Start()
    {
        bossMaxHP = BossController.bossHP;
       
    }

    // Update is called once per frame
    void Update()
    {
        bossCurrentHP = BossController.bossHP;
        bossMaxHP = BossController.maximumBossHP;
        print(bossCurrentHP);
        bossHealthFill.fillAmount = bossCurrentHP / bossMaxHP;


    }
}
