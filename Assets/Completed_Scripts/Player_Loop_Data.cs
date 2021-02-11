using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;
    public string name;
    public string description;
}
public class Player_Loop_Data : MonoBehaviour
{
    public Item[] myItems;
    void Start()
    {
        foreach (var item in myItems)
        {
            Debug.Log(item.name);
            if(item.itemID == 5)
            {
                Debug.Log("You have item with ID: 5");
            }
            else 
            {
                Debug.Log("You don't have item with ID: 5");
            }
        }
        for (int i =0; i < myItems.Length; i++)
        {
            Debug.Log(myItems[i].name);
            if(myItems[i].itemID == 5)
            {
                Debug.Log("You have item with ID: 5");
            }
            else 
            {
                Debug.Log("You don't have item with ID: 5");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomId = Random.Range(0, myItems.Length);
            Debug.Log(myItems[randomId].name);
        }
    }
}
