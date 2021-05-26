using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New God", menuName = "Create God")]

public class Gods :ScriptableObject
{
    public string godName;
    public Sprite godImage;
    public int godHealth;
    public int godDamage;
    public int godID;
    public int cardsToUnlock;
}
