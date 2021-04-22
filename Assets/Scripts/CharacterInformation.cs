using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInformation : MonoBehaviour
{

    //Base player stats 

    private int pHealth = 100;
    private int pDamage = 50;
    private int PCriticalDamage = 25;
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

        AddingGodsStats();


        godsNameTXT.text = SaveSelectedGod.saveGod.godName;
        godsHealth.text = pHealth.ToString();
        godsDamage.text = pDamage.ToString();
        godsCritDamage.text = PCriticalDamage.ToString();
    }



    public void AddingGodsStats()
    {
        pHealth = pHealth + SaveSelectedGod.saveGod.health;
        pDamage = pDamage + SaveSelectedGod.saveGod.damage;
        PCriticalDamage = PCriticalDamage + SaveSelectedGod.saveGod.critical_Damage;


    }

    
    void Update()
    {
        
    }
}
