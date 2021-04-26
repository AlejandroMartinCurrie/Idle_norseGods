using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSelectedGod : MonoBehaviour
{
    public static Gods saveGod;
    public static bool godSelected;
   public void SaveGodSelection(Gods save)
    {
        saveGod = save;
        godSelected = true;
        print(saveGod.godName);
    }



    public   void Update()
    {
        
    }

}
