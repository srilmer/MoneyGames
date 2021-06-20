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
    public GameObject button;
    public GameObject AIReading;
    private Vector3 ButtonStartPosition;
    GameObject roundManagerGO;
    RoundManager RoundManager;

    public void Start()
    {
        roundManagerGO = GameObject.Find("RoundManager");
        RoundManager = roundManagerGO.GetComponent<RoundManager>();
        ButtonStartPosition = button.transform.position;
        Time.timeScale = 0;
    }

    public void Update()
    {
        if (RoundManager.getPlayerAI())
        {
            Time.timeScale = 1;
            button.transform.position = new Vector3(10000, 10000);
            StartCoroutine(HideUIAI());
            AIReading.SetActive(true);
        }
        else
        {
            button.transform.position = ButtonStartPosition;
        }
    }

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
        players[roundManager.getPlayerRound()].AddMoney(150);
        players[roundManager.getPlayerRound()].UpdatePlayerText();
        Time.timeScale = 1;
        UI.SetActive(false);
    }

    IEnumerator HideUIAI()
    {
        yield return new WaitForSeconds(2f);
        AIReading.SetActive(false);

        Time.timeScale = 1;
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

        players[roundManager.getPlayerRound()].AddMoney(150);
        players[roundManager.getPlayerRound()].UpdatePlayerText();
        UI.SetActive(false);
    }

}
