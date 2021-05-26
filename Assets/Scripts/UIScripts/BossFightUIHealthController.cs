using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFightUIHealthController : MonoBehaviour
{
    public GameObject s_PlayerHealthBar;
    public GameObject b_PlayerHealthBar;
    public GameObject bossHealthBar;
    public GameObject vs_logoImage;




    public void Start()
    {
        s_PlayerHealthBar.SetActive(true);
        b_PlayerHealthBar.SetActive(false);
        bossHealthBar.SetActive(false);
        vs_logoImage.SetActive(false);
    }


    public void Update()
    {
        if(EnemySpawnController.callBoss)
        {
            s_PlayerHealthBar.SetActive(false);
            b_PlayerHealthBar.SetActive(true);
            bossHealthBar.SetActive(true);
            vs_logoImage.SetActive(true);
        }

    }

}
