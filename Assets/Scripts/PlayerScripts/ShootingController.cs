using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bulletToShoot;
    public Transform shootLocation;
    public int fireRate;
    float elapsedTime;
    public static bool haveShooted;
    public static bool autoMode;
    



    public void CreateBullet()
    {
        Instantiate(bulletToShoot, shootLocation);
    }

    private void Start()
    {
        fireRate = 1;
        autoMode = true;
    }


    public void ShootEnemyController()
    {
        if (elapsedTime > 1f / fireRate)
        {
            haveShooted = true;
            elapsedTime = 0f;
            CreateBullet();
        }
    }


    public void ShootBossController()
    {
        if (elapsedTime > 1f / fireRate)
        {
            haveShooted = true;
            elapsedTime = 0f;
            CreateBullet();
        }
    }



    public void AutoShooting()
    {

        if(autoMode)
        {
            autoMode = false;   
        }
        else
        {
            autoMode = true;
        }
    }


    public void ManualShooting()
    {
        if(!autoMode)
        {
            CreateBullet();
        }
       
    }


    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if(autoMode)
        {
            if (!EnemyDeathController.isDead)
            {
                ShootEnemyController();
            }

            if (!BossConrtoller.bossDead)
            {
                ShootBossController();
            }
        }

        
    }
}
