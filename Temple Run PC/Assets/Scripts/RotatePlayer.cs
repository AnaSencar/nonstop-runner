using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    private bool isPlayerInsideTrigger = false;
    private bool isLeftPlatform = false;
    private bool isRightPlatform = false;

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

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInsideTrigger)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                transform.Rotate(0, -90f, 0, Space.World);
                isPlayerInsideTrigger = false;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                transform.Rotate(0, 90f, 0, Space.World);
                isPlayerInsideTrigger = false;
            }
        }
    }
}
