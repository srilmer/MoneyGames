using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    [SerializeField]
    private Canvas kapper;

    [SerializeField]
    private Canvas brandweer;

    [SerializeField]
    private Canvas postbode;

    [SerializeField]
    private Canvas pizzaBezorger;

    [SerializeField]
    private Canvas boer;

    [SerializeField]
    private Canvas tandarts;

    private GameObject ThePlayer;

    private bool inTrigger;
    private Vector3 startPos;

    void Start()
    {
        // Get Player and playermovementscript info
        ThePlayer = GameObject.FindWithTag("Player");
        inTrigger = false;
        startPos = ThePlayer.transform.position;
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
            Debug.Log("(1) Player stayed inside the trigger, finding right UI to display.");
            Debug.Log("(2) Tag found: " + this.tag);
            switch (this.tag.ToString())
            {
                case "Kapper":
                    kapper.enabled = true;
                    break;
                case "Brandweer":
                    brandweer.enabled = true;
                    break;
                case "Postbode":
                    postbode.enabled = true;
                    Debug.Log("(3) Player landed on Postbode, activate UI");
                    Debug.Log("postboden ui status: " + postbode.enabled.ToString());
                    break;
                case "PizzaBezorger":
                    pizzaBezorger.enabled = true;
                    break;
                case "tandarts":
                    tandarts.enabled = true;
                    break;
                case "Boer":
                    boer.enabled = true;
                    break;
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        inTrigger = false;
    }
}