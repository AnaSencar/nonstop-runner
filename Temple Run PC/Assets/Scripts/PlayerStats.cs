using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int coinsCollected = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinsCollected += 1;
            Destroy(other.gameObject);
            Debug.Log(coinsCollected);
        }
    }
}
