using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public Transform enemyParent;
    public GameObject[] enemyPrefab;

    float spawnRange = 50;
    public float spawnRate = 1f;
    public float spawnTime = 3;

    private void Start()
    {
        Invoke("SpawnRandomEnemy", spawnTime + 1/spawnRate);
    }

    private void Update()
    {
        spawnRate += Time.fixedDeltaTime/600;

        if (spawnTime >= 0)
        spawnTime -= Time.fixedDeltaTime / 600;
    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Vector2 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange));

        GameObject newObject = Instantiate(enemyPrefab[enemyIndex], spawnPos, enemyPrefab[enemyIndex].transform.rotation);
        newObject.transform.SetParent(enemyParent);

        Invoke("SpawnRandomEnemy", spawnTime + 1 / spawnRate);
    }
}
