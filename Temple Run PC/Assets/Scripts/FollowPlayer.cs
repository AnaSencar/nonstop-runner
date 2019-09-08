using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        Vector3 newPositionOFLava = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.position = newPositionOFLava;
    }

}
