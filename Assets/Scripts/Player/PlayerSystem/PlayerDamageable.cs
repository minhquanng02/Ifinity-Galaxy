using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageable : Damageable
{
    public ValueBar healthBar;
    public PlayerSystem playerSystem;

    
    protected override void Start()
    {
        if (playerSystem == null)
            playerSystem = GameObject.Find("PlayerSystem").GetComponent<PlayerSystem>();
        maxHealth = playerSystem.maxHealth;

        base.Start();

        healthBar.SetMaxValue(playerSystem.maxHealth);
        healthBar.SetValue(currentHealth);
    }

    private void Update()
    {
        maxHealth = playerSystem.maxHealth;
        healthBar.SetMaxValue(playerSystem.maxHealth);
        healthBar.SetValue(currentHealth);
    }

    public override void TakeDamage(float attackDamage)
    {
        base.TakeDamage(attackDamage);
        healthBar.SetValue(currentHealth);

    }

    public void LifeSteal(float life)
    {
        currentHealth += life;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
        healthBar.SetValue(currentHealth);

    }

}
