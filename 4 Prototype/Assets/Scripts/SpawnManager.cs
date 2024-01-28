using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    public GameObject enemy2Prefabs;

    public GameObject[] powerupPrefabs;

    public int enemyCount;

    private int powerupNumber = 3;
    private int waveNumber = 1;

    private float limitRangeX = 9f;
    private float limitRangeZ = 9f;

    // Start is called before the first frame update
    void Start()
    {
        CreatePowerup();
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyController>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnPowerup(powerupNumber);
            SpawnEnemyWave(waveNumber);
        }
    }
    private void SpawnPowerup(int powerupToSpawn)
    {
        for (int i = 0; i < powerupToSpawn; i++)
        {
            CreatePowerup();
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            if (i % 2 == 0 && i != 0) {
                CreateEnemy2();
            }
            else
            {
                CreateEnemy();
            }
        }
    }

    private void CreatePowerup()
    {
        int randomPowerup = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[randomPowerup], GenerateSpawnPosition(), powerupPrefabs[randomPowerup].transform.rotation);
    }

    private void CreateEnemy()
    {
       
        Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
    }

    private void CreateEnemy2()
    {

        Instantiate(enemy2Prefabs, GenerateSpawnPosition(), enemy2Prefabs.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-limitRangeX, limitRangeX);
        float spawnPosZ = Random.Range(-limitRangeZ, limitRangeZ);

        Vector3 randomPosition = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPosition;
    }
}
