using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New God", menuName = "God")]

public class Gods : ScriptableObject
{
    public string godName;
    public string godDescription;

    public Sprite godArt;

    public int damage;
    public int fire_Rate;
    public int health;
    public int defence;
    public int critical_Damage;
    public int ability_Power;

    
    
}
