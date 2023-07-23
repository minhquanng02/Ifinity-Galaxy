using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : Shooting
{
    public EnemySystem enemySystem;

    protected override void Start()
    {
        if (enemySystem == null)
            enemySystem = GetComponentInParent<EnemySystem>();
        attackSpeed = enemySystem.attackSpeed;
    }

    protected void Update()
    {
        base.Shoot();
    }
}
