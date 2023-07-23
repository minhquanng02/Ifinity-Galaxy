using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelUI : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI maxHealthText;
    public TextMeshProUGUI lifeStealText;
    public TextMeshProUGUI attackSpeedText;
    public TextMeshProUGUI attackDamageText;

    public PlayerSystem playerSystem;
    public LevelSystem levelSystem;

    void Update()
    {
        levelText.text = "" + levelSystem.level;
        pointText.text = "" + levelSystem.point;
        speedText.text = "" + playerSystem.moveSpeed;
        maxHealthText.text = "" + playerSystem.maxHealth;
        lifeStealText.text = "" + playerSystem.lifeSteal;
        attackSpeedText.text = "" + playerSystem.attackSpeed;
        attackDamageText.text = "" + playerSystem.attackDamage;
    }

    public void SpeedUp()
    {
        levelSystem.point--;
        playerSystem.SpeedUp();
    }
    public void MaxHealthUp()
    {
        levelSystem.point--;
        playerSystem.MaxHealthUp();
    }
    public void LifeStealUp()
    {
        levelSystem.point--;
        playerSystem.LifeStealUp();
    }
    public void AttackSpeedUp()
    {
        levelSystem.point--;
        playerSystem.AttackSpeedUp();
    }
    public void AttackDamageUp()
    {
        levelSystem.point--;
        playerSystem.AttackDamageUp();
    }
}
