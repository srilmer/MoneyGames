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
        Instantiate(canvas_resultaat);
        canvas_investering.enabled = false;
    }

    public void CloseResultaat()
    {
        canvas_resultaat.enabled = false;
    }
}
