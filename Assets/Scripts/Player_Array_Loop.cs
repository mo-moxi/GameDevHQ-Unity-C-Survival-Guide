using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Array_Loop : MonoBehaviour
{
    public int[] itemID;
    public string[] itemName;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < itemID.Length; i++)
            {
                Debug.Log("ID: " + itemID[i] + " " + "Item Name: " + itemName[i]);
            }
        }
    }
}