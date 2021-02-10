using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_While_Loop : MonoBehaviour
{
    // Start is called before the first frame update
    // Warning: always allow the program to breath and always use 
    // an index incrementor or condition to break the loop.

    // e.g.
    // while(CONDITION)
    //{
    //  -- some code --
    // change CONDITION -- i++ etc.
    // (CONDITION can be anything changeable or measurable)
    //}
    void Start()
    {
        StartCoroutine(LoopRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawning something every second");
        }
    }
}
