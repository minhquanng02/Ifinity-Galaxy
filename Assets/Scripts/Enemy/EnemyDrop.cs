using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    LevelSystem level;

    private void Start()
    {
        level = GameObject.Find("Player").GetComponentInChildren<LevelSystem>();
    }
    public void Drop(int xpValue)
    {
        level.AddExperience(xpValue);
    }
}
