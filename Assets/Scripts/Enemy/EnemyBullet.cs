using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    public EnemySystem enemySystem;

    private void Start()
    {
        if (enemySystem == null)
            enemySystem = GetComponentInParent<EnemySystem>();
        attackDamage = enemySystem.attackDamage;
        attackRange = enemySystem.attackRange;
        bulletSpeed = enemySystem.bulletSpeed;
    }
}
