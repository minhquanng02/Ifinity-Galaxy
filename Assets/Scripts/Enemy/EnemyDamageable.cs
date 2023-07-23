using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageable : Damageable
{
     public EnemySystem enemySystem;
     EnemyDrop enemyDrop;
    

    protected override void Start()
    { 
        
        if (enemyDrop == null)
            enemyDrop = GetComponent<EnemyDrop>();
        maxHealth = enemySystem.maxHealth;

        base.Start();
        
    }

    

    protected override void Die()
    {
        base.Die();
        enemyDrop.Drop(enemySystem.xpDrop);
    }

    
}
