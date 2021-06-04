using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController
{
    Dictionary<string, int> bank = new Dictionary<string, int>();
    Dictionary<string, int> investment = new Dictionary<string, int>();
    List<string> players = new List<string>();

    public MoneyController(List<string> players){
        this.players = players;

        for (int i = 0; i < players.Count; i++){
            bank.Add(players[i], 0);
            investment.Add(players[i], 0);

            int value = bank[players[i]];
        }
    }

    // Test() is een tijdelijke methode om te checken of alles goedloopt
    public void Test()
    {
        for (int i = 0; i < players.Count; i++){
            Debug.Log(players[i]);
        }

        addMoney("Boer", 800);
        Debug.Log(getMoney("Boer"));

        subtractMoney("Boer", 900);
        Debug.Log(getMoney("Boer"));

        subtractMoney("Boer", 200);
        Debug.Log(getMoney("Boer"));

        investMoney("Boer");

        Debug.Log(getMoney("Boer"));
        Debug.Log(getInvestment("Boer"));

        investMoney("Boer");

        Debug.Log(getMoney("Boer"));
        Debug.Log(getInvestment("Boer"));

        investMoney("Boer");

        Debug.Log(getMoney("Boer"));
        Debug.Log(getInvestment("Boer")); 
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public int getMoney(string player){
        return bank[player];
    }

    public void addMoney(string player, int amount){
        if (bank.ContainsKey(player)){

            bank[player] = getMoney(player) + amount;

        }
        else {
            Debug.Log("I don't recognise player " + player + ", I can't add money!");
        }

    }

    public bool subtractMoney(string player, int amount){
        if (bank.ContainsKey(player)){
            if (getMoney(player) - amount >= 0){
                bank[player] = getMoney(player) - amount;
                return true;
            }
            else {
                Debug.Log(player + " doesn't have enough money!");
                return false;
            }
        }
        else {
            Debug.Log("I don't recognise player " + player + ", I can't subtract money!");
            return false;
        }

    }

    public int getInvestment(string player){
        return investment[player];
    }

    public bool investMoney(string player){

        int price = 100;
        int bonus = 50;

        if (bank.ContainsKey(player)){
            if (subtractMoney(player, price)){

            investment[player] = getInvestment(player) + bonus;
            return true;

            }
            else {
                return false;
            }           
        }
        else {
            Debug.Log("I don't recognise player " + player + ", I can't invest money!");
            return false;
        }
    }


}
