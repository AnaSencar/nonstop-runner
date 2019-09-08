using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class IncreaseMovementSpeed : MonoBehaviour
{
    [SerializeField] private float timeToIncreaseSpeed = 10f;
    [SerializeField] private float increaseSpeedAddition = 0.2f;
    private ThirdPersonCharacter thirdPersonCharacter;
    private float timePassed = 0f;

    private void Awake()
    {
        thirdPersonCharacter = GetComponent<ThirdPersonCharacter>();
    }

    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= timeToIncreaseSpeed)
        {
            timePassed = 0f;
            thirdPersonCharacter.M_MoveSpeedMultiplier = increaseSpeedAddition;
        }
    }

}
