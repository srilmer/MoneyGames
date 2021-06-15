using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button : MonoBehaviour
{
    [SerializeField]
    public Canvas canvas;

    public void HideUi()
    {
        canvas.enabled = false;
    }
}