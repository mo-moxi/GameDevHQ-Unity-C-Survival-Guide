using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Break_Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++) // break out of loop when i is 50
        {
            Debug.Log(i);

            if (i == 50)
            {
                break;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
