using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Change_Colour : MonoBehaviour
{
// Challenge
// Create a program where you assign a cube in the inspector and when key space is hit
// the cube is passed into a function called Change Color.
// The function should take both the GameObject and colour
// and the operation handle within the function

public GameObject cube;
    void Start()
    {
        
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.blue);
        }
    }
    private void ChangeColor(GameObject cube, Color newColor)
    {
        cube.GetComponent<MeshRenderer>().material.color = newColor;
    }
}
