using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour
{
    [SerializeField] bool isLeftPlatform = false;
    [SerializeField] bool isRightPlatform = false;
    private RotatePlayer rotatePlayer;

    private void Start()
    {
        rotatePlayer = GameObject.FindGameObjectWithTag("VirtualCamera").GetComponent<RotatePlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        rotatePlayer.IsPlayerInsideTrigger = true;
        SetPlatforms();
    }

    private void SetPlatforms()
    {
        rotatePlayer.IsRightPlatform = isRightPlatform;
        rotatePlayer.IsLeftPlatform = isLeftPlatform;
    }

}
