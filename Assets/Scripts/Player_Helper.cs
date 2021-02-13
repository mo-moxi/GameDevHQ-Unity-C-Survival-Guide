using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Helper : MonoBehaviour
{
    public bool randomColor;                // set this in the inspector to toggle random colour

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.CreatObject();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            UtilityHelper.ChangePosition(gameObject);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            UtilityHelper.ChangeColor(gameObject, Color.blue, randomColor);
        }
    }
}
