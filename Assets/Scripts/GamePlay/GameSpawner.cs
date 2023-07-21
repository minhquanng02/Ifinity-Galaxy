using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public Transform enemyParent;
    public GameObject[] enemyPrefab;

    float spawnRange = 50;

    private void Start()
    {
        Invoke("SpawnRandomEnemy", Random.Range(3, 5));
    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Vector2 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange));

        GameObject newObject = Instantiate(enemyPrefab[enemyIndex], spawnPos, enemyPrefab[enemyIndex].transform.rotation);
        newObject.transform.SetParent(enemyParent);

        Invoke("SpawnRandomEnemy", Random.Range(5, 7));
    }
}
