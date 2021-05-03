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

    public void CreateBullet()
    {
        Instantiate(bulletToShoot, shootLocation);
    }

    private void Start()
    {
        fireRate = 1;
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

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (!EnemyDeathController.isDead)
        {
            ShootEnemyController();
        }

        if(CallBossFight.bossIsAlive)
        {
            ShootBossController();
        }
    }
}
