using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public PowerData powerData;
    public LevelSystem levelSystem;

    public float bulletSpeed;
    public float attackRange;
    public float attackSpeed;
    public float moveSpeed;
    public float maxHealth;
    public float attackDamage;
    public float xpDrop;

    private void Awake()
    {
        levelSystem = GameObject.Find("Player").GetComponent<LevelSystem>();

        bulletSpeed = powerData.bulletSpeed + powerData.bulletSpeed * levelSystem.level * 0.1f;
        attackRange = powerData.attackRange;
        attackSpeed = powerData.attackSpeed + powerData.attackSpeed * levelSystem.level * 0.1f;
        moveSpeed = powerData.moveSpeed;
        maxHealth = powerData.maxHealth + powerData.maxHealth * levelSystem.level * 0.1f;
        attackDamage = powerData.attackDamage + powerData.attackDamage * levelSystem.level * 0.1f;
        xpDrop = powerData.xpDrop + powerData.xpDrop * levelSystem.level * 0.1f;
    }
}



