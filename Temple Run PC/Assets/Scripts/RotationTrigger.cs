using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour
{
    [SerializeField] bool isLeftPlatform = false;
    [SerializeField] bool isRightPlatform = false;
    private RotatePlayer rotatePlayer;

    private void Awake()
    {
        rotatePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<RotatePlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        rotatePlayer.IsPlayerInsideTrigger = true;
        SetPlatforms();
    }

    private void OnTriggerExit(Collider other)
    {
        rotatePlayer.IsPlayerInsideTrigger = false;
        SetPlatforms();
    }

    private void SetPlatforms()
    {
        rotatePlayer.IsRightPlatform = isRightPlatform;
        rotatePlayer.IsLeftPlatform = isLeftPlatform;
    }

}
