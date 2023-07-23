using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damageable : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth = 0;

    protected int waitTime = 1;
    public bool isDead = false;

    protected Dissolve dissolve;


    

    protected virtual void Start()
    {
        if (dissolve == null)
            dissolve = GetComponent<Dissolve>();
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
        }

    }

    public virtual void TakeDamage(float attackDamage)
    {
        if (!isDead)
        {

            currentHealth -= attackDamage;

            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }

    

    protected virtual void Die()
    {
        isDead = true;
        Invoke("DestroyOnDead", waitTime);

    }

    protected virtual void DestroyOnDead()
    {
        Destroy(gameObject);
    }

    
}
