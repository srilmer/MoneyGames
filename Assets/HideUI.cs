using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    private GameObject roundManagerGO;
    private RoundManager RoundManager;

    public void Start()
    {
        roundManagerGO = GameObject.Find("RoundManager");
        RoundManager = roundManagerGO.GetComponent<RoundManager>();
    }

    public void HideUi()
    {
        RoundManager.setGameStartStart();
        RoundManager.SetPlayerRound(RoundManager.getPlayerRound() + 1);
        Destroy(this.transform.parent.gameObject);
    }
}
