using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    // bill amount
    // tip
    // calculate total amount

    public float billSubTotal;                                          // bill sub-total set in inspector
    public float tipAmount = 20f;                                       // preset to 20% or set in inspector
    public float totalAmount;                                           // public to display in inspector

    // Start is called before the first frame update
    void Start()
    {
        // output bill subtotal; output tip amount; output total amount 
        totalAmount = billSubTotal + billSubTotal * (tipAmount / 100);
        Debug.Log("Your bill is: " + billSubTotal);
        Debug.Log("Your tip amount is: " + tipAmount);
        Debug.Log("Your bill total amount is: " + totalAmount);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
