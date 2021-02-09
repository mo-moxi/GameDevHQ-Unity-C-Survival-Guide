using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Points : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            points = 100;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            points = 50;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        // switch

        switch(points)
        {
            case 50:
            Debug.Log("You have 50 points");
            break;
            case 100:
            Debug.Log("You have 100 points");
            break;
            default:
            Debug.Log("You need 50 or 100 points to receive a message");
            break;
        }
    }
}
