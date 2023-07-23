using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ObjectPool objectPool;
    protected float attackDamage;
    protected float attackRange;
    protected float bulletSpeed;
    

    protected virtual void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);

        DestroyByDistance();
    }

    void DestroyByDistance()
    {
        var cam = Camera.main;
        var distanceFromCamera = Vector3.Distance(transform.position, cam.transform.position);

        if (distanceFromCamera > attackRange)
        {
            ResetObject();
        }
    }


    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        ResetObject();
        GameObject effect = objectPool.instance.GetPooledObject();
        effect.transform.position = transform.position;
        effect.SetActive(true);

        Damageable damageable = collision.gameObject.GetComponent<Damageable>();
        if (damageable != null)
        {
            damageable.TakeDamage(attackDamage);
        }
    }


    protected void ResetObject()
    {
        gameObject.SetActive(false);
    }
}
