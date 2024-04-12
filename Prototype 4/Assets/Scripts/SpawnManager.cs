using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWawe(waveNumber);
        Instantiate(powerUpPrefab,GenerateSpawnPosition(),powerUpPrefab.transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWawe(waveNumber);
            Instantiate(powerUpPrefab,GenerateSpawnPosition(),powerUpPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnposx = Random.Range(-spawnRange, spawnRange);
        float spawnposz = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnposx, 0, spawnposz);
        return randomPos;   
    }
    private void SpawnEnemyWawe(int enemysToSpawn)
    {
        for (int i = 0;i < enemysToSpawn;i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

        }
    }
}
