using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public static int bulletDamage = 1;
    public int bulletSpeed;


    private void Update()
    {
        transform.Translate(new Vector3(bulletSpeed, 0f, 0f) * Time.deltaTime);
    }
}
