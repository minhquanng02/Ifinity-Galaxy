using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int level;
    public float experience;
    public float experienceToNextLevel;
    public int point;

    public ValueBar xpBar;

   


    public LevelSystem()
    {
        level = 1;
        experience = 0;
        experienceToNextLevel = 100;
    }

    private void Start()
    {
        xpBar.SetMaxValue(experienceToNextLevel);
        xpBar.SetValue(experience);

    }

    public void AddExperience (float amount)
    {
        experience += amount;
        xpBar.SetValue(experience);

        while (experience >= experienceToNextLevel)
        {
            level++;
            point++;
            experience -= experienceToNextLevel;

            experienceToNextLevel  += experienceToNextLevel * 0.15f;

            xpBar.SetMaxValue(experienceToNextLevel);
            xpBar.SetValue(experience);
        }
    }

    
}
