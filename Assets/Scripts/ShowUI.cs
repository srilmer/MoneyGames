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
        if(player.CompareTag("Player") && inTrigger && (startPos != ThePlayer.transform.position))
        {
            roundManager.GetComponent<RoundManager>().setGameStateChoosing();
            switch (this.tag.ToString())
            {
                case "Kapper":
                    Instantiate(kapper);
                    break;
                case "Brandweer":
                    Instantiate(brandweer);
                    break;
                case "Postbode":
                    Instantiate(postbode);
                    break;
                case "PizzaBezorger":
                    Instantiate(pizzaBezorger);
                    break;
                case "Tandarts":
                    Instantiate(tandarts);
                    break;
                case "Boer":
                    Instantiate(boer);
                    break;
                case "Investeren":
                    Instantiate(investeren);
                    break; 
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        inTrigger = false;
    }
}