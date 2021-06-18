using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum round { Player1, Player2, Player3, Player4 }
public enum gameState { Start, ThrowingScreen, ThrowingAnimation, Walking, Choosing, Winner}



public class RoundManager : MonoBehaviour
{
    public int roundNumber = 1;
    public int playersCount = 4;
    public DiceManager diceManager;
    public GameObject playerTurnUI;
    public Text playerRoundText;
    public Text playerTurnText;
    public GameObject WinnerUI;

    private round round;
    public gameState gameState;

    private bool gameDone = false;

    private void Start()
    {
        round = round.Player1;
        gameState = gameState.Start;
    }

    void Update()
    {
        if(gameState == gameState.Start)
        {
            diceManager.Button.SetActive(false);
            playerTurnUI.SetActive(true);
        }
        if (gameState == gameState.ThrowingScreen)
        {
            diceManager.Button.SetActive(true);
            playerTurnUI.SetActive(false);
        }
        if(gameState == gameState.ThrowingAnimation)
        {
            diceManager.Button.SetActive(false);
            playerTurnUI.SetActive(false);
        }
        if (gameState == gameState.Winner)
        {
            WinnerUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public int getPlayerRound()
    {
        switch (round)
        {
            case round.Player1:
                return 0;
            case round.Player2:
                return 1;
            case round.Player3:
                return 2;
            case round.Player4:
                return 3;
            default:
                return 0;
        }
    }

    public void SetPlayerRound(int player)
    {
        switch (player)
        {
            case 0:
                round = round.Player1;
                playerRoundText.text = "Speler " + 1 + " is aan de beurt!";
                playerTurnText.text = "Speler 1";
                break;
            case 1:
                round = round.Player2;
                playerRoundText.text = "Speler " + 2 + " is aan de beurt!";
                playerTurnText.text = "Speler 2";
                break;
            case 2:
                round = round.Player3;
                playerRoundText.text = "Speler " + 3 + " is aan de beurt!";
                playerTurnText.text = "Speler 3";
                break;
            case 3:
                round = round.Player4;
                playerRoundText.text = "Speler " + 4 + " is aan de beurt!";
                playerTurnText.text = "Speler 4";
                break;
            default:
                round = round.Player1;
                playerRoundText.text = "Speler " + 1 + " is aan de beurt!";
                playerTurnText.text = "Speler 1";
                break;
        }
    }
    public void setGameStartStart()
    {
        gameState = gameState.Start;
    }
    public void setGameStateThrowingScreen()
    {
        gameState = gameState.ThrowingScreen;
    }
    public void setGameStateThrowingAnimation()
    {
        gameState = gameState.ThrowingAnimation;
    }
    public void setGameStateWalking()
    {
        gameState = gameState.Walking;
    }
    public void setGameStateChoosing()
    {
        gameState = gameState.Walking;
    }
}
