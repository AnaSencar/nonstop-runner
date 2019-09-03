using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] platformToSpawn;
    [SerializeField] Transform placeToSpawnPlatform;

    public void SpawnPlatform()
    {
        Vector3 positionOfObject = placeToSpawnPlatform.position;
        Quaternion rotationOfObject = placeToSpawnPlatform.rotation;
        int randomPlatformIndex = Random.Range(0, platformToSpawn.Length);
        Instantiate(platformToSpawn[randomPlatformIndex], positionOfObject, rotationOfObject);
    }


}
