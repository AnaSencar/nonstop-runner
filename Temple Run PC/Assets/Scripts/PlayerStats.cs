using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerStats : MonoBehaviour
{
    private int coinsCollected = 0;
    private bool isPlayerDead = false;
    private UISceneManager instance;

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

    private void Update()
    {
        if (isPlayerDead)
        {
            UISceneManager.instance.ShowUI();
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
