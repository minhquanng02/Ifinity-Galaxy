using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public PowerData powerData;

    public float bulletSpeed;
    public float attackRange;
    public float attackSpeed;
    public float moveSpeed;
    public int maxHealth;
    public int attackDamage;
    public int xpDrop;

    private void Start()
    {
        bulletSpeed = powerData.bulletSpeed;
        attackRange = powerData.attackRange;
        attackSpeed = powerData.attackSpeed;
        moveSpeed = powerData.moveSpeed;
        maxHealth = powerData.maxHealth;
        attackDamage = powerData.attackDamage;
        xpDrop = powerData.xpDrop;
    }
}
