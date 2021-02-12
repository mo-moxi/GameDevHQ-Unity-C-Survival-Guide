using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    // constructor
    public WeaponStats(string name, float fireRate, int ammoCount)
    {
    this.name = name;
    this.fireRate = fireRate;
    this.ammoCount = ammoCount;
    }
}

public class Player_WeaponStats : MonoBehaviour
{
    private WeaponStats blasters;
    private WeaponStats rockets;

    void Start()
    {
        blasters = new WeaponStats("Toby", 4f, 50);
        rockets = new WeaponStats("Oh, No!", 1f, 5);

        Debug.Log("Current weapon: " + blasters.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
