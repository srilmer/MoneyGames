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
    
    // All cards (Buttons)
    [SerializeField]
    public Button btn1;

    [SerializeField]
    public Button btn2;

    [SerializeField]
    public Button btn3;

    [SerializeField]
    public Button btn4;
    void Start()
    {
        
    }

    public void ReadStringInput(string s)
    {
        inv_bedrag = int.Parse(s);
        

        // zet de waarde die geinvesteerd is op het scherm.  
        text_invested_amount.text = inv_bedrag.ToString();


        // Randomize de 4 cards
        // 1. double your investment
        // 2. 1.5* your investment
        // 3. lose 50% of your investment
        // 4. lose entire investment

        // add value to the cards   
    }

    public void ShowInvestmentCards()
    {
        // Clear the input field
        input.text = "";
        int x = Random.Range(1,5);  // Range is nu 1-5 betekent tussen 1, 2, 3 en 4.  WERKT

        // Randomize de 4 cards
        // 1. double your investment
        // 2. 1.5* your investment
        // 3. lose 50% of your investment
        // 4. lose entire investment

        // add value to the cards
    }

    public void ShowInvestmentResult()
    {
        btn1.enabled = false;
        btn2.enabled = false;
        btn3.enabled = false;
        btn4.enabled = false;
    }
}


// [x] geld ophalen van inputfield
// [x] player klikt een knop
// [x] random een keuze maken tussen de 4 opties
// [ ] kaart animatie?
// [ ] Tonen welke optie de player gekregen heeft
// [ ] tonen hoeveel hij uitbetaald gaat worden/ of verloren heeft
