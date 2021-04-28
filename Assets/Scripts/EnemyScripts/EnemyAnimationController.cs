using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    public Animator enemyAnim;

    private void Update()
    {
        if(!EnemyDeathController.isDead)
        {
            enemyAnim.SetBool("Idle", true);
            
            
        }
        else
        {
            enemyAnim.SetBool("Idle", false);
            
        }
    }

}
