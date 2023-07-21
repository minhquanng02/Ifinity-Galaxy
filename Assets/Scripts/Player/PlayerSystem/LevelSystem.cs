using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int level;
    public int experience;
    public int experienceToNextLevel;

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

    public void AddExperience (int amount)
    {
        experience += amount;
        xpBar.SetValue(experience);

        while (experience >= experienceToNextLevel)
        {
            level++;
            experience -= experienceToNextLevel;

            experienceToNextLevel  += experienceToNextLevel*15 / 100;

            xpBar.SetValue(experience);
            xpBar.SetMaxValue(experienceToNextLevel);
        }
    }
}
