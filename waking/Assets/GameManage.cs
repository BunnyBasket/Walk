using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    private int coinsCollected = 0;
    public int totalCoins = 3; // Set the total number of coins

    void Start()
    {
    }

    public void CoinCollected()
    {
        coinsCollected++;

        if (coinsCollected >= totalCoins)
        {
            Debug.Log("Game Finish!");
        }
    }
}