using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Access_Arrays : MonoBehaviour
{
    public string[] names;
    public string[] items = new string[5];
    public int[] ages = new int[] { 4, 6, 39, 12, 15 };
    void Start()
    {
        Debug.Log(names[0]);
        Debug.Log(ages[2]);
        Debug.Log(items[1]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
