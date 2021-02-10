using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_For_Loops : MonoBehaviour
{
    public string myName = "Hobo";
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++) // counting up print out name
        {
            Debug.Log("My name is " + myName);
        }
        for (int i = 100; i > 0; i--) // counting down even numbers
        {
            if (i % 2 == 0)
                Debug.Log(i);
            if (i == 76)
                Debug.Log("i is " + i);
        }
        for (int i = 0; i < 100; i++) // counting up odd numbers
        {
            if (i % 2 == 1)
                Debug.Log(i);
        }
        Debug.Log("Loops has finihed");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
