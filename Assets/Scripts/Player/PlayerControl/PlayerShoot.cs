using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    public ObjectPool objectPool;
    public Transform firePoint;

    float nextFireTime = 0f;

    PlayerSystem playerSystem;

    private void Start()
    {
        if (playerSystem == null)
            playerSystem = GameObject.Find("PlayerSystem").GetComponent<PlayerSystem>();
    }


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
                nextFireTime = Time.time + 1f / playerSystem.attackSpeed;
            }
                
            
        }
    }
}
