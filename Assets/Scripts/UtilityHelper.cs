using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    // static classes cannot inherit from monobehaviour; there the follow methond
    // generates an error.
    // public void CreatObject()
    // {   
    // }

    // these static methods work without an error

public static void CreatObject()
{
    GameObject.CreatePrimitive(PrimitiveType.Sphere);
}

public static void ChangePosition(GameObject obj)
{
    //change position of obj
    obj.transform.position = Vector3.zero;
}

public static void  ChangeColor(GameObject obj, Color color, bool randomColor)
{
    if(randomColor == true)
        {
           color = new Color(Random.value, Random.value, Random.value);
        }
    obj.GetComponent<MeshRenderer>().material.color = color;
}
}
