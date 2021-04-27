using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPlayerLVL : MonoBehaviour
{
    public TMP_Text playerLVL;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerLVL.text = PlayerEXPgain.playerLVL.ToString();
    }
}
