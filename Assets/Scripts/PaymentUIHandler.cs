using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaymentUIHandler : MonoBehaviour
{
    [SerializeField]
    public Canvas kapper;

    [SerializeField]
    public Canvas brandweer;

    [SerializeField]
    public Canvas postbode;

    [SerializeField]
    public Canvas pizzaBezorger;

    [SerializeField]
    public Canvas boer;

    [SerializeField]
    public Canvas tandarts;

    
    public void ShowKapperBezoeker()
    {
        Instantiate(kapper);
    }

    public void ShowBrandweerBezoeker()
    {
        Instantiate(brandweer);
    }

    public void ShowPostBodeBezoeker()
    {
        Instantiate(postbode);
    }

    public void ShowPizzaBezorgerBezoeker()
    {
        Instantiate(pizzaBezorger);
    }

    public void ShowBoerBezoeker()
    {
        Instantiate(boer);
    }

    public void ShowTandartsBezoeker()
    {
        Instantiate(tandarts);
    }
}
