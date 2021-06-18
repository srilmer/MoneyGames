using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayerUi : MonoBehaviour
{
    public PlayerManager pm;
    public Text[] playerNameFields;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            playerNameFields[i].text = pm.players[i].name + "\nWerkloos" + "\n100 Euro";
        }
    }
}
