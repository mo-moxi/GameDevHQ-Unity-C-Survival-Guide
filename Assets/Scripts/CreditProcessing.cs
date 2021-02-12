using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CreditProcessing : Bank
{
    public int availableCash;

    public void ApproveLending()
    {
        Debug.Log("You are approved a loan");
    }
}
