using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // every item has a name
    // every item has a description
    // every item has an image icon
    // every item has an attack strength

    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public int attackStrength;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + itemDescription);
        Debug.Log("Attack strength: " + attackStrength);
    }


}
