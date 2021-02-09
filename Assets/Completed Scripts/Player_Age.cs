using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Age : MonoBehaviour
{
    public int myAge = 23;
    private int _legalAgeToDrive = 16;
    // Start is called before the first frame update
    void Start()
    {
        // if myAge is greater than or equal 16
        // print outt You can drive
        // else
        // print out You can't drive

        if (myAge >= _legalAgeToDrive)
        {
            Debug.Log("You can drive");
        }
        else
        {
            Debug.Log("You can't drive!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
