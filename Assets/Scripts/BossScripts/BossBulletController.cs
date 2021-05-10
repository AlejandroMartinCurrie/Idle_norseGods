using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    public int bossBulletSpeed;

    private void OnTriggerEnter2D(Collider2D bossBullet)
    {
        if (bossBullet.tag == "Player")
        {
            PlayerCharecterStats.playerOverAllHP -= BossController.bossDamage;
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Translate(new Vector3(-bossBulletSpeed,0f,0f)*Time.deltaTime);    
    }
}
