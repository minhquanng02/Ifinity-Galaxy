using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    PlayerSystem playerSystem;
    PlayerDamageable playerDmg;

    private void Start()
    {
        if (playerDmg == null)
            playerDmg = GameObject.Find("Player").GetComponent<PlayerDamageable>();
        if (playerSystem == null)
            playerSystem = GameObject.Find("PlayerSystem").GetComponent<PlayerSystem>();
        attackDamage = playerSystem.attackDamage;
        attackRange = playerSystem.attackRange;
        bulletSpeed = playerSystem.bulletSpeed;
    }

    protected override void Update()
    {
        attackDamage = playerSystem.attackDamage;
        base.Update();

    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        playerDmg.LifeSteal(playerSystem.lifeSteal);

    }
}
