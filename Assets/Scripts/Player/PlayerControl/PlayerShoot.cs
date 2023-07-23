using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : Shooting
{
    PlayerSystem playerSystem;

    protected override void Start()
    {
        base.Start();
        if (playerSystem == null)
            playerSystem = GameObject.Find("PlayerSystem").GetComponent<PlayerSystem>();
        attackSpeed = playerSystem.attackSpeed;
    }

    private void Update()
    {
        attackSpeed = playerSystem.attackSpeed;

    }
}
