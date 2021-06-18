using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MockPlayers : MonoBehaviour
{
    List<string> players = new List<string>();

    void Start()
    {

        players.Add("Boer");
        players.Add("Kapper");
        players.Add("Postbode");

        MoneyController moneyController = GameObject.FindObjectOfType(typeof(MoneyController)) as MoneyController;
        moneyController.addPlayers(players);
        moneyController.Test();

        //MoneyController moneyController = gameObject.AddComponent

        //MoneyController moneyController = new MoneyController(players);

        //moneyController.Test();
        //Player1.text = "Boer: " + moneyController.getMoney("Boer");
        
    }
}
