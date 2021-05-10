using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{

    public void PlayerDeathController()
    {
        if(PlayerCharecterStats.playerOverAllHP <=0)
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        PlayerDeathController();
    }
}
