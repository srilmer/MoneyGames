using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inv_logica : MonoBehaviour
{
    [SerializeField]
    public InputField Investering;
        
    // Start is called before the first frame update
    void Start()
    {
        // Empty inputfield
        Investering.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
