using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStartTurn : MonoBehaviour
{
    GameObject roundManagerGO;
    RoundManager RoundManager;
    public GameObject button;
    public GameObject UI;
    public GameObject AIChoosing;
    private Vector3 ButtonStartPosition;

    public void Start()
    {
        roundManagerGO = GameObject.Find("RoundManager");
        RoundManager = roundManagerGO.GetComponent<RoundManager>();
        ButtonStartPosition = button.transform.position;
    }
    public void Update()
    {
        if (RoundManager.getPlayerAI())
        {
            button.transform.position = new Vector3(10000, 10000);
            StartCoroutine(HideUIAI());
            AIChoosing.SetActive(true);
        }
        else
        {
            button.transform.position = ButtonStartPosition;
        }
    }

    IEnumerator HideUIAI()
    {
        yield return new WaitForSeconds(4f);
        AIChoosing.SetActive(false);
        RoundManager.setGameStateThrowingScreen();
    }
}
