﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclesPrefabs;
    [SerializeField] Transform[] obstacleSpawnPoints;

    private void Awake()
    {
        obstacleSpawnPoints = GetComponentsInChildren<Transform>();
    }

    void Start()
    {
        SpawnObstacle();
    }

    private void SpawnObstacle()
    {
        for (int i = 1; i < obstacleSpawnPoints.Length; i++)
        {
            if (ShouldSpawnOnThisSpawnPoint())
            {
                Vector3 positionOfObject = obstacleSpawnPoints[i].position;
                Quaternion rotationOfObject = obstacleSpawnPoints[i].rotation;
                int whichObstacleToSpawn = Random.Range(0, obstaclesPrefabs.Length);
                Instantiate(obstaclesPrefabs[whichObstacleToSpawn], positionOfObject, rotationOfObject);
            }
        }
    }

    private bool ShouldSpawnOnThisSpawnPoint()
    {
        int shouldSpawnRandomer = Random.Range(0, 100);
        return (shouldSpawnRandomer >= 50 ? true : false);
    }

}
