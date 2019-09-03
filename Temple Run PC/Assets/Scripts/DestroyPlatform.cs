using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    [SerializeField] float timeToDestroyPlatform = 20f;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, timeToDestroyPlatform);
    }
}
