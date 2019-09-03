using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] platformToSpawn;
    [SerializeField] Transform[] placeToSpawnPlatform;

    public void SpawnPlatform()
    {
        int randomSpawnPlace = Random.Range(0, placeToSpawnPlatform.Length);
        Vector3 positionOfObject = placeToSpawnPlatform[randomSpawnPlace].position;
        Quaternion rotationOfObject = placeToSpawnPlatform[randomSpawnPlace].rotation;
        int randomPlatformIndex = Random.Range(0, platformToSpawn.Length);
        Instantiate(platformToSpawn[randomPlatformIndex], positionOfObject, rotationOfObject);
    }


}
