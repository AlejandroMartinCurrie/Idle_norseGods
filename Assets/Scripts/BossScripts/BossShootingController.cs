using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShootingController : MonoBehaviour
{

    public GameObject bossBullet;
    public Transform shootingLocation;
    public float elapsedTime;

    

    public void CreateBossBullet()
    {
        Instantiate(bossBullet, shootingLocation);
    }

    
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(BossController.bossCombat)
        {
            if(elapsedTime >= 5)
            {
                CreateBossBullet();
                elapsedTime = 0f;
            }

        }

    }
}
