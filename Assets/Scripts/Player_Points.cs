using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Points : MonoBehaviour
{
    // Challenge
    // create a variable to store point
    [SerializeField]
    private int points;

    // has said message

    private bool _hasSaidMessage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if we hit the space key
        // add 10 points

        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
            Debug.Log("Points: " + points);
        }

        // if points is greater than 50 AND (&&) hasSaidMessage  is false
        // print out You're awesome!

        if (points >= 50 && _hasSaidMessage == false)
        {
            Debug.Log("You're awesome!");
            _hasSaidMessage = true;
        }
    }
}
