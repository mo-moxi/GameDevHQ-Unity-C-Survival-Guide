using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ultimate_Printout : MonoBehaviour
{
    //Challenge
    //Create a program that prints out 0-10, then prints 
    //out only even number to 20 and only odd number to 30
    void Start()
    {
        /* for (int i = 0; i < 30; i++)
         {
             if (i < 10)                     // print out 0 - 10
             {
                 Debug.Log(i);
             }
             else if (i > 9 && i < 21)       // print out evens to 20
             {
                 if (i % 2 == 0)
                 {
                     Debug.Log(i);
                 }
             }
             else if (i > 20)                // print out odds to 30
             {
                 if (i % 2 == 1)
                 {
                     Debug.Log(i);
                 }
             }*/
        // shorter version
        for (int i = 0; i < 30; i++)
        {
            // print numbers from 1 to 10
            if (i < 10)
            {
                Debug.Log(i);
            }
            else if (i > 9 && i < 20 && (i % 2 == 0))
            {
                Debug.Log(i);
            }
            else if (i > 20 && (i % 2 == 1))
            {
                Debug.Log(i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
