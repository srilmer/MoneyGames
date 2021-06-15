using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTile_trigger_script : MonoBehaviour

{
    bool firstTurn;

    // Start is called before the first frame update
    void Start()
    {
        firstTurn = true;
        // Move player to start location
    }

    // Update is called once per frame
    void Update()
    {
        // Movement per turn

        // is turn? -> Move ??px to left, right, front or back.

        // Check if next location is availible if not, maybe turn needed.
    }

    // upon collision with another GameObject
     private void OnTriggerEnter(Collider other)
    {
        if (firstTurn){
            Debug.Log("Dit is de eerste ronde, geen geld nu.");
            firstTurn = false;
        }
        else {
            Debug.Log("Zakgeld en investeringsgeld!");

            // moneycontroller
            //int investmentMoney = moneyController.getInvestment(PLAYERNAME);
            //moneyController.addMoney(PLAYERNAME, 100 + investmentMoney);
        }
    }
}
