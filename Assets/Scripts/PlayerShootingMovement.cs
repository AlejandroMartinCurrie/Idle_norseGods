using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingMovement : MonoBehaviour
{
   
    void Update()
    {
        if(ShootingController.haveShooted)
        {
            transform.position = new Vector3(-2.8f, 0.5f, 0f);
            
        }
        else
        {
            transform.position = new Vector3(0f, 0.5f, 0f);
        }
       
    }
}
