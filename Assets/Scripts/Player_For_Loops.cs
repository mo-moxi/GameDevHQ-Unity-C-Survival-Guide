using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_For_Loops : MonoBehaviour
{
    public string myName = "Hobo";
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("My name is " + myName);
        }

        Debug.Log("Loop has finihed");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
