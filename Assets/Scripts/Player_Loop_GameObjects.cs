using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Loop_GameObjects : MonoBehaviour
{
    public GameObject[] cubes;
    public float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.green;
            }

    }
}
