using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public GameObject AIScreen;
    public GameObject PlayerUI;
    public RoundManager rm;
    public void StartGame()
    {
        AIScreen.SetActive(false);
        PlayerUI.SetActive(true);
        rm.gameState = gameState.Start;
    }

}
