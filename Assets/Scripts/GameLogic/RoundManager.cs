using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum round { Player1, Player2, Player3, Player4 }

public class RoundManager : MonoBehaviour
{
    public int roundNumber = 1;
    public int playersCount = 4;
    public ThrowDice throwDice;
    public WaypointMovement[] wp;

    private round round;

    private bool gameDone = false;

    private void Start()
    {
        round = round.Player1;
    }

    void Update()
    {
        while(!gameDone)
        {
            for(int i = 1; i < playersCount-1; i++)
            {
                SetPlayerRound(i);
                //throwDice.ThrowDices();
                wp[i].setMoveto(5);
                //TileTrigger ()

            }
            roundNumber++;
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
}
