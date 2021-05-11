using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Boss", menuName = "Create Boss")]
public class Boss : ScriptableObject
{
    public string bossName;
    public int bossHealth;
    public int bossDMG;
    public Sprite bossSprite;
    public bool bossCompleted;
    public int bossGoldDrop;
    public float bossExp;
}
