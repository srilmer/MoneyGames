using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button : MonoBehaviour
{
    public void HideUi()
    {
        GameObject roundManager = GameObject.Find("RoundManager");
        roundManager.GetComponent<RoundManager>().setGameStartStart();
        Destroy(this.transform.parent.gameObject);
    }
}