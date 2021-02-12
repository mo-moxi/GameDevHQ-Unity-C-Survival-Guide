using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Return_Array : MonoBehaviour
{
    public GameObject[] players;

    void Start()
    {
        players = GetAllPlayers();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var p in players)
            {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);    
            }
        }
    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        return allPlayers;
    }
}
