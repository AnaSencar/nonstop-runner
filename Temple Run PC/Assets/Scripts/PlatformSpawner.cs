using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] platformToSpawn;
    [SerializeField] Transform[] placeToSpawnPlatform;

    public void SpawnPlatform()
    {
        for (int i = 0; i < placeToSpawnPlatform.Length; i++)
        {
            Vector3 positionOfObject = placeToSpawnPlatform[i].position;
            Quaternion rotationOfObject = placeToSpawnPlatform[i].rotation;
            int randomPlatformIndex = Random.Range(0, platformToSpawn.Length);
            Instantiate(platformToSpawn[randomPlatformIndex], positionOfObject, rotationOfObject);
        }
    }
}
