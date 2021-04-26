using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInformation : MonoBehaviour
{

    //Base player stats 

    private int pHealth = 100;
    private int pDamage = 50;
    private int pCriticalDamage = 25;
    private int pDefence = 30;
    private int pAbilityPower = 10;
    private int pFireRate = 5;
    
    //  text gameobjects that will be displayed in the game

    [SerializeField] Text godsNameTXT;
    [SerializeField] Text godsHealth;
    [SerializeField] Text godsDamage;
    [SerializeField] Text godsCritDamage;
    [SerializeField] Text godsDefence;
    [SerializeField] Text godsAbilityPower;
    [SerializeField] Text godsFireRate;







    void Start()
    {
        if (SaveSelectedGod.godSelected)
        {
            AddingGodsStats(); 
        }
        else
        {           
            godsNameTXT.text = "Farmer";
            
        }
    }



    public void AddingGodsStats()
    {
        pHealth += SaveSelectedGod.saveGod.health;
        pDamage += SaveSelectedGod.saveGod.damage;
        pCriticalDamage += SaveSelectedGod.saveGod.critical_Damage;
        pDefence += SaveSelectedGod.saveGod.defence;
        pAbilityPower += SaveSelectedGod.saveGod.ability_Power;
        pFireRate += SaveSelectedGod.saveGod.fire_Rate;

        godsNameTXT.text = SaveSelectedGod.saveGod.godName;

        print(SaveSelectedGod.saveGod.godName);
    }

    
    void Update()
    {

        //godsNameTXT.text = SaveSelectedGod.saveGod.godName;
        godsHealth.text = pHealth.ToString();
        godsDamage.text = pDamage.ToString();
        godsCritDamage.text = pCriticalDamage.ToString();
        godsDefence.text = pDefence.ToString();
        godsAbilityPower.text = pAbilityPower.ToString();
        godsFireRate.text = pFireRate.ToString();
    }
}
