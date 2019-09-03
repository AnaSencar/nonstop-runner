using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    PlatformSpawner platformSpawner;

    private void Awake()
    {
        platformSpawner = GetComponentInParent<PlatformSpawner>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            platformSpawner.SpawnPlatform();
        }
    }
}
