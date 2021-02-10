using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_For_Loop_Presentation : MonoBehaviour
{
    public int apples;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddApplesRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator AddApplesRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(0.5f);

        }
    }
}
