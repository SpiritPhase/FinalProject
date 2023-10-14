using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public float spawnInterval = 10.0f; 
    public Transform spawnPoint; 

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
      ZombieMove zombie = newEnemy.GetComponent<ZombieMove>();

        if (zombie != null)
        {
           zombie.SetSpawner(this); 
        }
    }

    public void ReplaceEnemy()
    {
        Invoke("SpawnEnemy", 20.0f); 
    }
}


