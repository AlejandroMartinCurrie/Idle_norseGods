using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSelectedGod : MonoBehaviour
{
    public static Gods saveGod;
   public void SaveGodSelection()
    {
        saveGod = FindObjectOfType<GodSelection>().currentGod;
        print(saveGod.godName);
    }
   
}
