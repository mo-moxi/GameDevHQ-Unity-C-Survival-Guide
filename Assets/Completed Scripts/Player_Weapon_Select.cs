using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon_Select : MonoBehaviour
{
    public int weaponID;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (weaponID)
        {
            case 0:
                Debug.Log("You selected the gun");
                break;
            case 1:
                Debug.Log("You selected the knife");
                break;
            case 2:
                Debug.Log("You selected the machine gun");
                break;
            default:
                Debug.Log("Invalid weapon");
                break;
        }
    }
}
