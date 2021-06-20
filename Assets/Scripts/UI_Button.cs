using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    private GameObject roundManagerGO;
    private RoundManager RoundManager;
    private GameObject nextButton;
    private Vector3 buttonPosition;

    private GameObject AIText;

    public void Awake()
    {
        roundManagerGO = GameObject.Find("RoundManager");
        RoundManager = roundManagerGO.GetComponent<RoundManager>();

        nextButton = GameObject.Find("button_next");

        AIText = GameObject.Find("AIHappyText");
        AIText.SetActive(false);

        try
        {
            buttonPosition = nextButton.transform.position;
        }
        catch
        {
            //some errorhandling
        }
    }
    public void Update()
    {
        if(RoundManager.getPlayerAI())
        {          
            nextButton.transform.position = new Vector3(10000, 10000);
            AIText.SetActive(true);
            StartCoroutine(HideUIAI());
        }
    }

    public void HideUi()
    {
        RoundManager.setGameStartStart();
        RoundManager.SetPlayerRound(RoundManager.getPlayerRound() + 1);
        Destroy(this.transform.parent.gameObject);
    }

    IEnumerator HideUIAI()
    {
        yield return new WaitForSeconds(4f);
        AIText.SetActive(false);
        //RoundManager.setGameStartStart();
        RoundManager.SetPlayerRound(RoundManager.getPlayerRound() + 1);
        Destroy(this.transform.parent.gameObject);
    }
}