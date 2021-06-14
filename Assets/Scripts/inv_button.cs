using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inv_button : MonoBehaviour
{
    [SerializeField]
    public Canvas canvas_investering;
    public Canvas canvas_resultaat;

    public void CloseInvestingOpenResults()
    {
        canvas_investering.enabled = false;
        canvas_resultaat.enabled = true;
    }

    public void CloseResultaat()
    {
        canvas_resultaat.enabled = false;
    }

    // functie voor investering ofzo...
}
