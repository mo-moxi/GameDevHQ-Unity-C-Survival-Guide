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
            foreach (var item in itemName)
            {
                if (item == "c")
                    Debug.Log("Item name: " + item);
            }
            foreach (var ID in itemID)
            {
                if (ID == 3)
                    Debug.Log("Item ID: " + ID);
            }
            /*      for (int i = 0; i < itemID.Length; i++)
                    {
                        Debug.Log("ID: " + itemID[i] + " " + "Item Name: " + itemName[i]);
                        if (itemID[i] == 3)
                        {
                            Debug.Log("Item name: " + itemName[i]);
                        }
                        if (itemName[i] == "e")
                        {
                            Debug.Log("Item " + itemName[i] + " exits.");
                        }
                    }
            */
        }
    }
}