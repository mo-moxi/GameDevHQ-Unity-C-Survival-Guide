using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    Item sword;
    Item hammer;
    Item bread;
    
    void Start()
    {
        sword = new Item("Bob", 1, "This is a mighty sword");

        hammer = new Item("Hammer", 2, "This is a hammer");

        bread = CreateItem("Bread", 3, "The is bread");

        Debug.Log(bread.name);

    }


    void Update()
    {
        
    }
    private Item CreateItem(string name, int id, string description)
    {
        Item item = new Item(name, id, description);
        return item;
    }
}
