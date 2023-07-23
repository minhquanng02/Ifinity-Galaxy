using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    public PowerData powerData;

    public float bulletSpeed;
    public float attackRange;
    public float attackSpeed;
    public float moveSpeed;
    public float maxHealth;
    public float attackDamage;
    public float lifeSteal;
    public float xpDrop;

    private void Start()
    {
        bulletSpeed = powerData.bulletSpeed;
        attackRange = powerData.attackRange;
        attackSpeed = powerData.attackSpeed;
        moveSpeed = powerData.moveSpeed;
        maxHealth = powerData.maxHealth;
        attackDamage = powerData.attackDamage;
        lifeSteal = powerData.lifeSteal;
        xpDrop = powerData.xpDrop;
    }

    public void SpeedUp()
    {
        Debug.Log("speed up");
        moveSpeed += moveSpeed * 0.03f;
    }
    public void MaxHealthUp()
    {
        Debug.Log("health up");
        maxHealth += maxHealth * 0.5f;
    }
    public void LifeStealUp()
    {
        Debug.Log("life steal up");
        lifeSteal += 3 * 0.5f;
    }
    public void AttackSpeedUp()
    {
        Debug.Log("attack speed up");
        attackSpeed += attackSpeed * 0.3f;

    }
    public void AttackDamageUp()
    {
        Debug.Log("attack damage up");
        attackDamage += attackDamage * 0.5f;

    }

}
