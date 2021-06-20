using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inv_logica : MonoBehaviour
{
    [SerializeField]
    public InputField input;                // Bedrag van het inputveld, hoeveel geld de player wil investeren

    [SerializeField]
    public Text text_invested_amount;       // Het bedrag dat de player wil investeren wordt getoond op deze text
    private int inv_bedrag;                 // Het bedrag dat de speler wil investeren wordt hier opgeslagen als INT.
    
    [SerializeField]
    public Text playerEarnings;

    [SerializeField]
    public RawImage monopolyMan;

    [SerializeField]
    public Canvas investment_UI;

    [SerializeField]
    public Button btn_next;
    
    // All cards (Buttons)
    [SerializeField]
    public Button btn1;

    [SerializeField]
    public Button btn2;

    [SerializeField]
    public Button btn3;

    [SerializeField]
    public Button btn4;

    private GameObject player;
    private GameObject roundManager;

    public void Start()
    {
        playerEarnings.gameObject.SetActive(false);
        monopolyMan.gameObject.SetActive(false);
        btn_next.gameObject.SetActive(false);

        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(true);
        btn4.gameObject.SetActive(true);

        InputField txt_input = GameObject.Find("Input_investeren_bedrag").GetComponent<InputField>();
        inv_bedrag = int.Parse(txt_input.text);

        roundManager = GameObject.Find("RoundManager");

        switch (roundManager.GetComponent<RoundManager>().getPlayerRound())
        {
            case 0:
                player = GameObject.Find("Player 1");
                break;
            case 1:
                player = GameObject.Find("Player 2");
                break;
            case 2:
                player = GameObject.Find("Player 3");
                break;
            case 3:
                player = GameObject.Find("Player 4");
                break;
        }

        player.GetComponent<Player>().PayMoney(inv_bedrag);
        // zet de waarde die geinvesteerd is op het scherm.  
        text_invested_amount.text = inv_bedrag.ToString();
    }

    public void ShowInvestmentCards()
    {
        // Clear the input field
        input.text = "";
    }

    public void ShowInvestmentResult()
    {
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        btn4.gameObject.SetActive(false);

        int x = Random.Range(1,5);  // Range is nu 1-5 betekent tussen 1, 2, 3 en 4.  WERKT

        switch (x)
        {
            case 1:
                inv_bedrag = inv_bedrag * 2;            // Double input
                player.GetComponent<Player>().AddMoney(inv_bedrag);
                playerEarnings.text = "Super, je hebt je investering verdubbelt, je krijgt: " + inv_bedrag + ", gefeliciteerd!";
                break;
            case 2:
                inv_bedrag = (inv_bedrag * 3) / 2;      // Gives 1.5 times input
                player.GetComponent<Player>().AddMoney(inv_bedrag);
                playerEarnings.text = "Je investering heeft het goed gedaan. je krijgt: " + inv_bedrag + ", gefeliciteerd!";
                break;
            case 3:
                inv_bedrag = inv_bedrag / 2;         // halved the input
                player.GetComponent<Player>().AddMoney(inv_bedrag);
                playerEarnings.text = "Je bent een gedeelte van je investering kwijt, je krijgt: " + inv_bedrag + ", terug";
                break;
            case 4:
                inv_bedrag = 0;                         // lost all investmented
                playerEarnings.text = "Wat jammer, je hebt je investering verloren. Volgende keer beter.";
                break;
        }

        // investerings UI uitzetten en plaats maken voor het resultaat
        text_invested_amount.enabled = true;
        playerEarnings.gameObject.SetActive(true);
        monopolyMan.gameObject.SetActive(true);
        btn_next.gameObject.SetActive(true);
    }

    public void Continue()
    {
        // Investerings UI terug zetten voor de volgende keer.
        text_invested_amount.enabled = true;
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(true);
        btn4.gameObject.SetActive(true);

        

        // resultaat van investering verbergen
        playerEarnings.enabled = false;
        monopolyMan.enabled = false;
        btn_next.enabled = false;
        
        // UI verbergen
        Destroy(GameObject.Find("Canvas_investeren_resultaat(Clone)"));
        Destroy(GameObject.Find("Canvas_investering(Clone)"));

        GameObject roundManager = GameObject.Find("RoundManager");
        roundManager.GetComponent<RoundManager>().setGameStartStart();

        //mc.addMoney((rm.getPlayerRound() + 1), inv_bedrag);
    }

    public void AddInvestment(int amount)
    {
        inv_bedrag = amount;
        Debug.Log(inv_bedrag);
    }
}
