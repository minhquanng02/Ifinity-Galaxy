using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    public ObjectPool objectPool;

    float nextFireTime = 0f;
    float attackRate = 2f;

    public Transform firePoint;



    public void Shoot()
    {
        GameObject bullet = objectPool.instance.GetPooledObject();

        if (bullet != null)
        {
            if (Time.time >= nextFireTime)
            {
                bullet.transform.position = firePoint.transform.position;
                bullet.transform.rotation = firePoint.transform.rotation;

                bullet.SetActive(true);
                nextFireTime = Time.time + 1f / attackRate;
            }
                
            
        }
    }
}
