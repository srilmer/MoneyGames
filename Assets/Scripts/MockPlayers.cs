using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MockPlayers : MonoBehaviour
{
    // Start is called before the first frame update

    // Deze class vervangt het startscherm en stuurt een mock lijst met spelers naar de money controller.

    List<string> players = new List<string>();

    //public Text Player1;

    


    void Start()
    {

        // players.Add("Boer");
        // players.Add("Kapper");
        // players.Add("Postbode");

        // MoneyController moneyController = GameObject.FindObjectOfType(typeof(MoneyController)) as MoneyController;
        // moneyController.addPlayers(players);
        // moneyController.Test();

        //MoneyController moneyController = gameObject.AddComponent

        //MoneyController moneyController = new MoneyController(players);

        //moneyController.Test();
        //Player1.text = "Boer: " + moneyController.getMoney("Boer");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
