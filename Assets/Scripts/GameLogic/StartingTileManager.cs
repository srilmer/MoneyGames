using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingTileManager : MonoBehaviour
{
    int startCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StartingTile"))
        {
            startCount++;

            if (startCount <3){
                Debug.Log("Dit is de eerste ronde, geen geld nu.");
            }
            else {
                Debug.Log("Zakgeld en investeringsgeld!");

                // moneycontroller
                //int investmentMoney = moneyController.getInvestment(gameObject.name);
                //moneyController.addMoney(gameObject.name, 100 + investmentMoney);
            }
        }
    }
}
