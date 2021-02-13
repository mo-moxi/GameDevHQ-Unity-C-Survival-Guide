using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private bool _isGameOver;

    public bool IsGameOver
    {
        get { return _isGameOver; }
        set
        {
            if (value == true)
            {
                Debug.Log("Oh no! The game is over");
            }
            _isGameOver = value;
        }
    }

    private void Start()
    {
        IsGameOver = false;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // Debug.Log("Space pressed");
            IsGameOver = true;
        }
    }

    public void GameOver()
    {
        IsGameOver = true;
        // Call the UI Manager and enable the game over screen
    }
}
