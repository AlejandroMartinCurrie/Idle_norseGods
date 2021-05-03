using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBossSpriteController : MonoBehaviour
{
    public Boss newBoss;

    // Update is called once per frame
    void Update()
    {
        if(!BossConrtoller.bossDead)
        {
            GetComponent<SpriteRenderer>().sprite = newBoss.bossSprite;
        }
    }
}
