using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MyMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start()");
        MyMethod();
        Debug.Log("Completed calling MyMethod()");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void MyMethod()
    {
        Debug.Log("MyMethod()");
    }
}
