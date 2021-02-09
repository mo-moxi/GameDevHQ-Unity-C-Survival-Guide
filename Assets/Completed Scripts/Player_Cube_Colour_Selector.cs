using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cube_Colour_Selector : MonoBehaviour
{
    public int keyPressed;
    public GameObject cube;
    private MeshRenderer _cube;                      // referenced MeshRenderer to shorten switch code
    // Start is called before the first frame update
    void Start()
    {
        _cube = cube.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            keyPressed = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            keyPressed = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            keyPressed = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            keyPressed = 3;
        }
        // switch

        switch (keyPressed)
        {
            case 0:
                _cube.material.color = Color.blue;
                break;
            case 1:
                _cube.material.color = Color.red;
                break;
            case 2:
                _cube.material.color = Color.green;
                break;
            case 3:
                _cube.material.color = Color.black;
                break;
        }
    }
}
