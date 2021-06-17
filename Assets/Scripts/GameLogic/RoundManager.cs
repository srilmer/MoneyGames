using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum round { Player1, Player2, Player3, Player4 }
public enum gameState { Start, ThrowingScreen, ThrowingAnimation, Walking, Choosing}

public class RoundManager : MonoBehaviour
{
    public int roundNumber = 1;
    public int playersCount = 4;
    public DiceManager diceManager;
    public GameObject playerTurnUI;

    private round round;
    private gameState gameState;

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
    }

    
    private void SetPlayerRound(int player)
    {
        switch (player)
        {
            case 1:
                round = round.Player1;
                break;
            case 2:
                round = round.Player2;
                break;
            case 3:
                round = round.Player3;
                break;
            case 4:
                round = round.Player4;
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
}
