using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public Item[] items;
    public Weapon sword = new Weapon();
    public Consumable bread = new Consumable();

    void Start()
    {
        foreach(var item in items)
            {
                Debug.Log(item.name);
            }

        for(int i = 0; i <items.Length; i++)
            {
                Debug.Log(items[i].description);
            }
            
        Debug.Log(items[1].id);
    }

    void Update()
    {
        
    }

}
