using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ObjectPool objectPool;

    PlayerSystem playerSystem;

    private void Start()
    {
        if (playerSystem == null)
        playerSystem = GameObject.Find("PlayerSystem").GetComponent<PlayerSystem>();
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * playerSystem.bulletSpeed);

        DestroyByDistance();
    }

    void DestroyByDistance()
    {
        var cam = Camera.main;
        var distanceFromCamera = Vector3.Distance(transform.position, cam.transform.position);

        if (distanceFromCamera > playerSystem.attackRange)
        {
            ResetObject();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ResetObject();
        GameObject effect = objectPool.instance.GetPooledObject();
        effect.transform.position = transform.position;
        effect.SetActive(true);

        Damageable damageable = collision.gameObject.GetComponent<EnemyDamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage(playerSystem.attackDamage);
        }
    }


    void ResetObject()
    {
        gameObject.SetActive(false);
    }
}
