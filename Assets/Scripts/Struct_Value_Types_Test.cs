using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public struct Item2 // Value type -- Stack
    {
        public string name;
        public int itemID;
        
        public Item2(string name, int itemID)
        {
            this.name = name;
            this.itemID = itemID;
        }
    }
    public class Item3   // Reference type -- Heap
    {
        public string name;
        public int itemID;

        public Item3(string name, int itemID)
        {
            this.name = name;
            this.itemID = itemID;
        }
    }
public class Struct_Value_Types_Test : MonoBehaviour
{
    Item3 sword = new Item3("Sword", 1);  // reeference type

    Item2 bread;                          // value type

    void Start()
    {
    bread.name="Bread";
    bread.itemID = 2;

    Debug.Log("Sword current name: " + sword.name );
    ChangeValue(sword);
    Debug.Log("Sword current name (after method): " + sword.name );

    Debug.Log("Bread current name: " + bread.name );
    ChangeValue(bread);
    Debug.Log("Bread current name (after method): " + bread.name );
    }

    void ChangeValue(Item2 structItem) // value type
    {
        structItem.name = "Dirty bread";
        Debug.Log(structItem.name);
    }
    // additional value types: bool, bytes, char, doubles, float, int long, structs

    void ChangeValue(Item3 classItem)  // reference type   
    {
        classItem.name = "Master Sword";
    }
    // additional reference types: strings, all arrays, classes, and delegates
}
