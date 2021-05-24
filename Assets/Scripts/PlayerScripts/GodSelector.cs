using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodSelector : MonoBehaviour
{
    public Gods god;

    
    void Start()
    {
        GetComponent<Image>().sprite = god.godImage;
        
    }
    public void sasman()
    {
        FindObjectOfType<PlayerCharecterStats>().currentSelectedGod = god;
    }
   
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
