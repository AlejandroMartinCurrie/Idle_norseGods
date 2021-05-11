using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Enemy",menuName = "CreateEnemy")]
public class Enemies :ScriptableObject
{
    public string enemyName;
    public int enemyHealth;
    public Sprite enemySprite;
    public float enemyExpDrop;
    public int goldDrop;
    //public bool enemyStageCompleted;
    
    
}
