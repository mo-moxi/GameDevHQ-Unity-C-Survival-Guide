using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Speed : MonoBehaviour
{
    //Challenge
    //Create a program that increments the speed when the S key is pressed
    //A decrements the speed
    //When the speed is greater than 20, print out "Slow Down!"
    //When the speed is 0, print out "Speed up"
    //Speed cannot go below zero
    public int speed = 0;
    public int speedInc = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += speedInc;
        }
        if (Input.GetKeyDown(KeyCode.A) && speed > 0)
        {
            speed -= speedInc;
        }
        if (speed > 20)
        {
            Debug.Log("Slow Down!");
        }
        else if (speed == 0)
        {
            Debug.Log("Speed up!");
        }
        // GameDevHQ less than 0 solution
        // if (speed < 0)
        // {
        //      speed = 0;
        // }
    }
}
