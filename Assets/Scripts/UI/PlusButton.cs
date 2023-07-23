using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlusButton : MonoBehaviour
{
    public UnityEvent<bool> onActive;
    LevelSystem levelSystem;

    private void Start()
    {
        levelSystem = GameObject.Find("Player").GetComponent<LevelSystem>();
    }

    private void Update()
    {
        onActive?.Invoke(levelSystem.point > 0);
    }
}
