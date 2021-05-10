using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissingBullet : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D bulletCol)
    {
        if (bulletCol.CompareTag("Bullet"))
        {
            Destroy(bulletCol.gameObject);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
