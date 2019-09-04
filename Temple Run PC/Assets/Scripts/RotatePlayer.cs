using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class RotatePlayer : MonoBehaviour
{
    private bool isPlayerInsideTrigger = false;
    private bool isLeftPlatform = false;
    private bool isRightPlatform = false;
    private ThirdPersonCharacter thirdPersonCharacter;

    public bool IsPlayerInsideTrigger
    {
        set
        {
            isPlayerInsideTrigger = value;
        }
    }

    public bool IsLeftPlatform
    {
        set
        {
            isLeftPlatform = value;
        }
    }

    public bool IsRightPlatform
    {
        set
        {
            isRightPlatform = value;
        }
    }

    private void Awake()
    {
        thirdPersonCharacter = GetComponent<ThirdPersonCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInsideTrigger)
        {
            if(Input.GetKeyDown(KeyCode.Q) && isLeftPlatform)
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y - 90f, transform.rotation.z);
                Vector3 movement = transform.forward * 2f;
                thirdPersonCharacter.Move(movement, false, false);
            }
            else if (Input.GetKeyDown(KeyCode.E) && isRightPlatform)
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y + 90f, transform.rotation.z);
                Vector3 movement = transform.forward * 2f;
                thirdPersonCharacter.Move(movement, false, false);
            }
        }
    }
}
