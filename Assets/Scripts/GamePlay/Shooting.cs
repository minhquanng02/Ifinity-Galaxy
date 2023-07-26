using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public ObjectPool objectPool;
    public Transform firePoint;
    public Damageable dmg;


    protected float nextFireTime = 0f;
    protected float attackSpeed;

    protected virtual void Start()
    {
        if (dmg == null)
            dmg = GetComponentInParent<Damageable>();
    }

    public void Shoot()
    {
        GameObject bullet = objectPool.instance.GetPooledObject();

        if (bullet != null && !dmg.isDead)
        {
            if (Time.time >= nextFireTime)
            {
                bullet.transform.position = firePoint.transform.position;
                bullet.transform.rotation = firePoint.transform.rotation;

                bullet.SetActive(true);
                nextFireTime = Time.time + 1f / attackSpeed;
            }
        }
    }
}
