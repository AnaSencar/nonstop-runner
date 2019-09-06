﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] coinPrefab;
    [SerializeField] Transform[] coinSpawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        coinSpawnPoints = GetComponentsInChildren<Transform>();
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        if (ShouldSpawnCoins())
        {
            int randomSpawnLocation = Random.Range(1, coinSpawnPoints.Length);
            int whichPrefabToSpawn = Random.Range(0, coinPrefab.Length);
            Instantiate(coinPrefab[whichPrefabToSpawn], coinSpawnPoints[randomSpawnLocation]);
        }
    }

    private bool ShouldSpawnCoins()
    {
        int shouldSpawnRandomer = Random.Range(0, 100);
        return (shouldSpawnRandomer >= 50 ? true : false);
    }
    
}