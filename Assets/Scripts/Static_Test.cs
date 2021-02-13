using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Test : MonoBehaviour
{
    // use below for non-static
    // private Score _score;

    void Start()
    {   
       // sue below for non-static
       // _score = GetComponent.Find("Score Keeper").GetComponent<Score>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // add 10 to score
            // use below for non-static
            // _score.score += 10;

            // static
            Score.score +=10;
            Debug.Log("Current Static Score: " + Score.score);
        }
    }
}
