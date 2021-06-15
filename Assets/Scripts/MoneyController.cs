using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    Dictionary<string, int> bank = new Dictionary<string, int>();
    Dictionary<string, int> investment = new Dictionary<string, int>();
    Dictionary<string, Text> playerTexts = new Dictionary<string, Text>();

    List<string> players = new List<string>();

    public Text Player1;
    public Text Player2;
    public Text Player3;
    public Text Player4;
    public Text Player5;
    public Text Player6;
    
    List<Text> textList = new List<Text>();
    

    // public MoneyController(List<string> players){
    //     this.players = players;

    //     for (int i = 0; i < players.Count; i++){
    //         bank.Add(players[i], 0);
    //         investment.Add(players[i], 0);

    //         int value = bank[players[i]];
    //     } 
    // }


    void Start()
    {
        textList.Add(Player1);
        textList.Add(Player2);
        textList.Add(Player3);
        textList.Add(Player4);
        textList.Add(Player5);
        textList.Add(Player6);

        foreach (Text p in textList){
           p.text = "";
        }

    }

    void Update()
    {

    }

    public void addPlayers(List<string> players)
    {
        this.players = players;

        for (int i = 0; i < players.Count; i++){
            bank.Add(players[i], 0);
            investment.Add(players[i], 0);

            int value = bank[players[i]];

            playerTexts.Add(players[i], textList[i]);

            updateMoneyText(players[i]);
        }
    }

    public void updateMoneyText(string player){
        playerTexts[player].text = player + ": " + bank[player];

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

        updateMoneyText(player);

    }

    public bool subtractMoney(string player, int amount){
        if (bank.ContainsKey(player)){
            if (getMoney(player) - amount >= 0){
                bank[player] = getMoney(player) - amount;
                updateMoneyText(player);
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
