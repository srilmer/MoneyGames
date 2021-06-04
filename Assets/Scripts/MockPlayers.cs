using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockPlayers : MonoBehaviour
{
    // Start is called before the first frame update

    // Deze class vervangt het startscherm en stuurt een mock lijst met spelers naar de money controller.

    List<string> players = new List<string>();

    void Start()
    {

        players.Add("Boer");
        players.Add("Kapper");
        players.Add("Postbode");

        MoneyController moneyController = new MoneyController(players);

        moneyController.Test();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
