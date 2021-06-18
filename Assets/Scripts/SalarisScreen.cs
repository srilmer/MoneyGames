using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SalarisScreen : MonoBehaviour
{
    public GameObject UI;
    public RoundManager roundManager;
    public Player[] players;
    private GameObject PlayerText;
    public void HideUI()
    {
        switch (roundManager.getPlayerRound())
        {
            case 0:
                PlayerText = GameObject.Find("Player1");
                break;
            case 1:
                PlayerText = GameObject.Find("Player2");
                break;
            case 2:
                PlayerText = GameObject.Find("Player3");
                break;
            case 3:
                PlayerText = GameObject.Find("Player4");
                break;
        }
        players[roundManager.getPlayerRound()].AddMoney(100);
        PlayerText.GetComponent<UnityEngine.UI.Text>().text = players[roundManager.getPlayerRound()].GetComponent<Player>().playerName + "\n" +
                players[roundManager.getPlayerRound()].GetComponent<Player>().playerJob + "\n" + players[roundManager.getPlayerRound()].GetComponent<Player>().playerMoney;
        Time.timeScale = 1;
        UI.SetActive(false);
    }
}
