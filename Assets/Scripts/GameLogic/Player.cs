using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public RoundManager rm;
    public string playerName;
    public int playerMoney = 100;
    public string playerJob = "Werkloos";
    public Text playerText;
    public bool isAI;

    public void AddMoney(int value)
    {
        playerMoney += value;
        if(playerMoney >= 1000)
        {
            rm.gameState = gameState.Winner;
        }
    }

    public void PayMoney(int value)
    {
        playerMoney -= value;
    }

    public void UpdatePlayerText()
    {
        playerText.text = playerName + "\n" +
                playerJob + "\n" + playerMoney;
    }
}
