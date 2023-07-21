using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damageable : MonoBehaviour
{
    protected int maxHealth;
    public int currentHealth = 0;

    protected int waitTime = 2;

    public Dissolve dissolve;

    Collider2D cld;

    

    protected virtual void Start()
    {
        cld = GetComponent<Collider2D>();
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
        }

    }

    public virtual void TakeDamage(int attackDamage)
    {
        currentHealth -= attackDamage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        dissolve.isDissolving = true;
        cld.enabled = false;

        Invoke("DestroyOnDead", waitTime);
    }

    void DestroyOnDead()
    {
        Destroy(gameObject);
    }

    
}
