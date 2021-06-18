using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoneGameButton : MonoBehaviour
{
    public Text PlayerText;
    public RoundManager rm;
    private void Start()
    {
        int playerround = rm.getPlayerRound() + 1;
        PlayerText.text = "Speler "+ playerround.ToString() + " Heeft Gewonnen!";
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
