using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTest
{
    GameManager gm = new GameManager();

    public void Test()
    {
        gm.Speed = 40f;
    }
}
public class GameManager : MonoBehaviour
{
    private bool _isGameOver;
    public bool AutoSet { get; private set; } // can also use protected 

    private float _speed;

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

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
        AutoSet = IsGameOver;
        Speed = 10;
        Debug.Log(_speed);
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
