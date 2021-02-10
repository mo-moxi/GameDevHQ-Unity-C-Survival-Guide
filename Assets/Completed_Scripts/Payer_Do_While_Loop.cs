using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payer_Do_While_Loop : MonoBehaviour
{
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            Debug.Log(i);
            if (i < 50)
            {
                i++;
            }
        } while (i < 50);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
