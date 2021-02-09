using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // create a variable to store your name
    // create a variable to store your age
    // create a variable to store your speed
    // create a variable to store your health
    // create a variable to store a status (bool)
    // create a variable to store your ammo count        

    public string myName = "Hobo";
    public int myAge = 22;
    public float mySpeed = 15.7f;
    public int myHealth = 10;
    public int myScore = 10;
    public bool hasAllKeys;
    public int myAmmo = 50;

    void Start()
    {
        Debug.Log("My name is: " + myName + ", and I'm " + myAge + " years old.");
        Debug.Log("I can run as fast as " + mySpeed + "m/s for a metre, and my health used to be a whopping " + myHealth + "!");
        Debug.Log("I don't like guns but have " + myAmmo + " bullets.");
        Debug.Log("Do I have the keys? " + hasAllKeys +"!");
        Debug.Log("And I once scored " + myScore + " points at cribbage!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
