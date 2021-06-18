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

    void Start()
    {
        // Get Player and playermovementscript info
        ThePlayer = GameObject.FindWithTag("Player");
        inTrigger = false;
        startPos = ThePlayer.transform.position;
        roundManager = GameObject.Find("RoundManager");
        
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
            roundManager.GetComponent<RoundManager>().setGameStateChoosing();
            switch (this.tag.ToString())
            {
                case "Kapper":
                    player.GetComponent<Player>().playerJob = "Kapper";
                    Instantiate(kapper);
                    break;
                case "Brandweer":
                    Instantiate(brandweer);
                    player.GetComponent<Player>().playerJob = "Brandweer";
                    break;
                case "Postbode":
                    Instantiate(postbode);
                    player.GetComponent<Player>().playerJob = "Postpode";
                    break;
                case "PizzaBezorger":
                    Instantiate(pizzaBezorger);
                    player.GetComponent<Player>().playerJob = "PizzaBezorger";
                    break;
                case "Tandarts":
                    Instantiate(tandarts);
                    player.GetComponent<Player>().playerJob = "Tandarts";
                    break;
                case "Boer":
                    Instantiate(boer);
                    player.GetComponent<Player>().playerJob = "Boer";
                    break;
                case "Investeren":
                    Instantiate(investeren);
                    break; 
            }

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
            
            PlayerText.GetComponent<UnityEngine.UI.Text>().text = player.GetComponent<Player>().playerName + "\n" +
                player.GetComponent<Player>().playerJob + "\n" + player.GetComponent<Player>().playerMoney;
        }
    }

    void OnTriggerExit(Collider player)
    {
        inTrigger = false;
    }
}