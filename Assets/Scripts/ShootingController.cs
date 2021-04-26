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
        haveShooted = true;
        Instantiate(bulletToShoot, shootLocation);

    }

    private void Start()
    {
        fireRate = 1;
    }
    private void Update()
    {
        elapsedTime += Time.deltaTime;
       
        if(!EnemyDeathController.isDead)
        {
            if (elapsedTime > 1f / fireRate)
            {
                elapsedTime = 0f;
                CreateBullet();
            }
        }
        
    }
}
