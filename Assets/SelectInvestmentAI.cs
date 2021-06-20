using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectInvestmentAI : MonoBehaviour
{
    public GameObject investAIText;
    public GameObject investButton;
    public GameObject backButton;

    private GameObject roundManagerGO;
    public GameObject inputField;
    public Text playerMoneyField;

    private RoundManager RoundManager;

    private Vector3 investButtonPostion;
    private Vector3 backButtonPosition;
    public Canvas canvas_resultaat;
    public Canvas canvas_investering;

    public void Start()
    {
        roundManagerGO = GameObject.Find("RoundManager");
        RoundManager = roundManagerGO.GetComponent<RoundManager>();
        investAIText.SetActive(false);

        playerMoneyField.text = "€" + RoundManager.getThisPlayerMoney();
        try
        {
            investButtonPostion = investButton.transform.position;
            backButtonPosition = backButton.transform.position;
        }
        catch
        {
            //some errorhandling
        }
    }
    public void Update()
    {
        if (RoundManager.getPlayerAI())
        {
            backButton.transform.position = new Vector3(10000, 10000);
            investButton.transform.position = new Vector3(10000, 10000);
            investAIText.SetActive(true);
            inputField.SetActive(false);
            StartCoroutine(HideUIAI());
        }
        else
        {
            inputField.SetActive(true);
            investButton.transform.position = investButtonPostion;
            backButton.transform.position = backButtonPosition;
        }
    }

    IEnumerator HideUIAI()
    {
        yield return new WaitForSeconds(4f);
        investAIText.SetActive(false);
        Destroy(this.gameObject);
        Instantiate(canvas_resultaat);
    }
}
