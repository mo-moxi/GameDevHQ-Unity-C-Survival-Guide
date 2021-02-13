using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevHQ.FileBase.Gatling_Gun;

public class MyTest : MonoBehaviour
{
    
    Gatling_Gun turret;
    void Start()
    {
        turret = GameObject.Find("Gatling_Gun").GetComponent<Gatling_Gun>();
        turret.ammoCount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
