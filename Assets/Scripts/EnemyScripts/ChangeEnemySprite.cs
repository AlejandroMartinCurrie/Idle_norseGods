using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnemySprite : MonoBehaviour
{
    public Enemies newEnemi;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = newEnemi.enemySprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
