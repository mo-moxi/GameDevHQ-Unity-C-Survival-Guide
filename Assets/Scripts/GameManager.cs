using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get { return isGameOver; }
        set
        {
            if (value == true)
            {
                Debug.Log("Oh no! The game is over");
            }
            isGameOver = value;
        }
    }

    void Start()
    {
        isGameOver = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // Debug.Log("Space pressed");
            isGameOver = true;
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        // Call the UI Manager and enable the game over screen
    }
}
