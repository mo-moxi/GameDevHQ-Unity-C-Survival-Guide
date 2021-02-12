using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]                                       // use System.Serializable here 
                                                            // and SerializeField on the class variable
                                                            // to see them in the inspector
public class Item 
{
    public string name;
    public int id;
    public string description;
    public Sprite icon;
    
    public Item(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
