using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stage", menuName = "Create Stage")]
public class Stages : ScriptableObject
{

    public Boss stageBoss;
    public Enemies stageEnemy;
    public Sprite backgroundImage;
    public float killsForBoss;
    
}
