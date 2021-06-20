using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    [SerializeField]
    public Canvas kapper;

    [SerializeField]
    public Canvas brandweer;

    [SerializeField]
    public Canvas postbode;

    [SerializeField]
    public Canvas pizzaBezorger;

    [SerializeField]
    public Canvas boer;

    [SerializeField]
    public Canvas tandarts;

    [SerializeField]
    public Canvas investeren;

    private GameObject ThePlayer;

    private bool inTrigger;
    private Vector3 startPos;

    private GameObject roundManager;
    private GameObject PlayerText;
    private GameObject paymentUI;

    void Start()
    {
        // Get Player and playermovementscript info
        ThePlayer = GameObject.FindWithTag("Player");
        inTrigger = false;
        startPos = ThePlayer.transform.position;
        roundManager = GameObject.Find("RoundManager");
        paymentUI = GameObject.Find("PaymentUIHandler");


    }

    IEnumerator OnTriggerEnter(Collider player)
    {      
        inTrigger = true;
        yield return new WaitForSeconds(1);
        
        // Check if the object has 'player' tag
        // Check if the object is in the trigger after 2 seconds
        // Check if the player has moved from it's original location
        if (player.CompareTag("Player") && inTrigger && (startPos != ThePlayer.transform.position))
        {
            switch (player.GetComponent<Player>().playerName)
            {
                case "Speler 1":
                    PlayerText = GameObject.Find("Player1");
                    break;
                case "Speler 2":
                    PlayerText = GameObject.Find("Player2");
                    break;
                case "Speler 3":
                    PlayerText = GameObject.Find("Player3");
                    break;
                case "Speler 4":
                    PlayerText = GameObject.Find("Player4");
                    break;
            }

            roundManager.GetComponent<RoundManager>().setGameStateChoosing();
            switch (this.tag.ToString())
            {
                case "Kapper":
                    if (player.GetComponent<Player>().playerJob == "Werkloos")
                    {
                        Instantiate(kapper);
                        player.GetComponent<Player>().playerJob = "Kapper";
                    }
                        
                    else
                        {
                            player.GetComponent<Player>().PayMoney(20);
                            paymentUI.GetComponent<PaymentUIHandler>().ShowKapperBezoeker();
                        }
                    
                    break;
                case "Brandweer":
                    
                    
                    if (player.GetComponent<Player>().playerJob == "Werkloos")
                    {
                        Instantiate(brandweer);
                        player.GetComponent<Player>().playerJob = "Brandweer";
                    }
                    else
                        { 
                            player.GetComponent<Player>().PayMoney(20);
                            paymentUI.GetComponent<PaymentUIHandler>().ShowBrandweerBezoeker();
                        }
                    break;
                case "Postbode":
                    
                    if (player.GetComponent<Player>().playerJob == "Werkloos")
                    {
                        Instantiate(postbode);
                        player.GetComponent<Player>().playerJob = "Postpode";
                    }
                        
                    else
                        { 
                            player.GetComponent<Player>().PayMoney(20);
                            paymentUI.GetComponent<PaymentUIHandler>().ShowPostBodeBezoeker();
                        }
                    break;
                case "PizzaBezorger":
                    
                    if (player.GetComponent<Player>().playerJob == "Werkloos")
                    {
                        Instantiate(pizzaBezorger);
                        player.GetComponent<Player>().playerJob = "PizzaBezorger";
                    }
                       
                    else
                        { 
                            player.GetComponent<Player>().PayMoney(20);
                            paymentUI.GetComponent<PaymentUIHandler>().ShowPizzaBezorgerBezoeker();
                        }
                    break;
                case "Tandarts":
                    
                    if (player.GetComponent<Player>().playerJob == "Werkloos")
                    {
                        Instantiate(tandarts);
                        player.GetComponent<Player>().playerJob = "Tandarts";
                    }
                        
                    else
                        { 
                            player.GetComponent<Player>().PayMoney(20);
                            paymentUI.GetComponent<PaymentUIHandler>().ShowTandartsBezoeker();
                        }
                    break;
                case "Boer":
                    
                    if (player.GetComponent<Player>().playerJob == "Werkloos")
                    {
                        Instantiate(boer);
                        player.GetComponent<Player>().playerJob = "Boer";
                    }                       
                    else
                        { 
                            player.GetComponent<Player>().PayMoney(20);
                            paymentUI.GetComponent<PaymentUIHandler>().ShowBoerBezoeker();
                        }
                    break;
                case "Investeren":
                    Instantiate(investeren);
                    break; 
            }


            try {
                player.GetComponent<Player>().UpdatePlayerText();
            }
            catch
            {
                //some fancy error handling to show playertext is empty because it's first round
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        inTrigger = false;
    }
}