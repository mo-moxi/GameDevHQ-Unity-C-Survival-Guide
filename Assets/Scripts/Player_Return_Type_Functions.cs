using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Return_Type_Functions : MonoBehaviour
{
    public int total;
    public int total2;

    void Start()
    {
        total = Sum(2, 7);
        total2 = Sum(9, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int Sum(int a, int b)
    {
        return a + b;
    }

}
