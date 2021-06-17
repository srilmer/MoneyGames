using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button : MonoBehaviour
{
    public void HideUi()
    {
        Destroy(this.transform.parent.gameObject);
    }
}