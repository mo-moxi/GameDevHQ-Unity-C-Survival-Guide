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

    public string[] names;
    public int[] ages;
    public string[] cars;

    void Start()
    {
        /*
            var namelength = names.Length - 1;
            Debug.Log(names[namelength]);
            var agelength = ages.Length - 1;
            Debug.Log(ages[agelength]);
            var carlength = cars.Length - 1;
            Debug.Log(cars[carlength]);
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Name: " + names[4] + ". Age: " + ages[4] + ". Car model: " + cars[4]);
        }
    }
}
