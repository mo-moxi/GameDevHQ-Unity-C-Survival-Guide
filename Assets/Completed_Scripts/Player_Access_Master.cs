using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Access_Master : MonoBehaviour
{
    //Challenge
    //Create an array of 5 names and print out the last name
    //Create an array of 5 ages and print out the last age
    //Create an array of 5 card models and associate them with 
    //each name and print out the last name's favourite car.

    // Randomly choose a name - part 2

    public string[] names;
    public int[] ages;
    public string[] cars;
    public int randomChoice;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomChoice = Random.Range(0, names.Length);
            Debug.Log(randomChoice);
            Debug.Log("Name: " + names[randomChoice] + ". Age: " + ages[randomChoice] + ". Car model: " + cars[randomChoice]);
        }
    }
}
