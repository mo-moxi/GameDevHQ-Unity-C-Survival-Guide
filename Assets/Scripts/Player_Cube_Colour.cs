using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cube_Colour : MonoBehaviour
{
    // Challenge
    //Create a program that when you hit the space key you increment a score value. When that score is
    //greater than 50, the cube turns green. At the start of the program, turn the cube red

    public GameObject cube;
    public int score;

    void Start()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
        }
        if (score = 50)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
