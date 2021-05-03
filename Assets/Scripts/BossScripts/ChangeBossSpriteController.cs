using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBossSpriteController : MonoBehaviour
{
    public Boss newBoss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CallBossFight.bossIsAlive)
        {
            GetComponent<SpriteRenderer>().sprite = newBoss.bossSprite;
        }
    }
}
