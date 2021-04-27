using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public Animator playerAnim;

    public void Update()
    {
        if(ShootingController.haveShooted)
        {
            playerAnim.SetBool("Shooting", true);

        }
        else
        {
            playerAnim.SetBool("Shooting",false);
        }

        
    }
}
