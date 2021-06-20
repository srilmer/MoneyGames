using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerAI : MonoBehaviour
{
    public Player player;

    public void ToggleAI(bool value)
    {
        if(value)
        {
            player.isAI = true;
            player.name = player.playerName + "(AI)";
        }
        else
        {
            player.isAI = false;
            string[] subs = player.name.Split('(');
            player.name = subs[0];
        }
    }
}
