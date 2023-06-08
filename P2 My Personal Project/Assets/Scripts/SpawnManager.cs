using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    private float zEnemySpawn = 10.0f;
    private float xSpawnRange = 24.0f;
    private float zPowerupRange = 10.0f;
    private float powerupSpawnTime = 5.0f;
    public float ySpawn = 1.45f;
    private float enemySpawnTime = 0.23f;
    private float startDelay = 1.0f;
    
    // This is where the loop of spawning things will happen 
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // this is where the enemy and powerups will be randomly spawned
    public void SpawnRandomEnemy()
    {
    float randomX = Random.Range(-xSpawnRange, xSpawnRange);
    int randomIndex = Random.Range(0, enemies.Length);

    Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);
        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }
    void SpawnPowerup()
    {
      float randomX = Random.Range(-xSpawnRange, xSpawnRange);  
      float randomZ = Random.Range(-zPowerupRange, zPowerupRange);
      
      Vector3 spawnPos = new Vector3(randomX, ySpawn + 0.85f, randomZ);
      Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
    
}

