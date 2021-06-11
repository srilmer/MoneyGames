using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum round { Player1, Player2, Player3, Player4 }

public class NewBehaviourScript : MonoBehaviour
{
    public int roundNumber = 0;
    public int playersCount = 4;

    public round round;

    private void Start()
    {
        round = round.Player1;
    }

    void Update()
    {
        
    }
}
