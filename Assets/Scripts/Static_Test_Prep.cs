using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string name;
    public int itemID;

    public static int itemCount;
    
    public Item()
    {
        itemCount ++;
    }
}

public class Static_Test_Prep : MonoBehaviour
{


    void Start()
    {
        Item sword = new Item();      
        Item bread = new Item();
        Item cape = new Item();  
        Item fish = new Item();

        Debug.Log("Item Count: " + Item.itemCount);
    }

    void Update()
    {
        
    }
}
