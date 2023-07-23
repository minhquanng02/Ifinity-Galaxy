using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashDamage : MonoBehaviour
{
    EnemySystem enemySystem;

    protected void Start()
    {
        if (enemySystem == null)
            enemySystem = GetComponent<EnemySystem>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable damageable = collision.gameObject.GetComponent<PlayerDamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage(enemySystem.attackDamage);
        }
    }
}
