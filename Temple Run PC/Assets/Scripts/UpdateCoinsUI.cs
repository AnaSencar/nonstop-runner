using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCoinsUI : MonoBehaviour
{
    private PlayerStats playerStats;

    private void Awake()
    {
        playerStats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
    }

    private void Update()
    {
        GetComponent<Text>().text = playerStats.CoinsCollected.ToString();
    }

}
