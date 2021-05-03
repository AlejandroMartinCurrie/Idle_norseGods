using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoShooterController : MonoBehaviour
{
    public Button attackbutton;
    void Update()
    {
        if(ShootingController.autoMode)
        {
            attackbutton.GetComponentInChildren<Text>().text = "Auto";
        }
        else
        {
            attackbutton.GetComponentInChildren<Text>().text = "Manual";
        }
    }
}
