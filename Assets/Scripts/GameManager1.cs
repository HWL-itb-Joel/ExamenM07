using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public int Coins = 0;
    public TextMeshProUGUI coinsText;

    public void Awake()
    {
        if(GameManager.gameManager != null && GameManager.gameManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void CoinCollected()
    {
        Coins++;
        coinsText.text = "Coins: " + Coins;
    }
}
