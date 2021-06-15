using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingTileManager : MonoBehaviour
{
    int startCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int startCount = 0;
    }

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
