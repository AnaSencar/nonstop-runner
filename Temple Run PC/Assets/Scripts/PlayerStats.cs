using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerStats : MonoBehaviour
{
    private int coinsCollected = 0;
    private bool isPlayerDead = false;

    public int CoinsCollected
    {
        get
        {
            return coinsCollected;
        }
    }

    public bool IsPlayerDead
    {
        get
        {
            return isPlayerDead;
        }
        set
        {
            isPlayerDead = value;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinsCollected += 1;
            Destroy(other.gameObject);
        }
    }
}
