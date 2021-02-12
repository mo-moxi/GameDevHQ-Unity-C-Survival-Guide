using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RU_Alive : MonoBehaviour
{
    // Challenge
    // Create a program that check if the player is dead or not.
    // Hitting the space key damages the player by a random amount
    // If the player's health is less than 1, print out "The player died"
    // Bonus: Prevent the player damage function after death and no negative health
    public int health;
    public bool isDead;

    void Start()
    {
        health = Random.Range(0, 20);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            Damage(Random.Range(0, 5));   
        }
    }
    private void Damage(int damageAmount)
    {
        health -= damageAmount;
        
        if(IsDead() == true)
        {
            health = 0;
            Debug.Log("Oops, your player died");
        }
    }
    public bool IsDead()
    {
        return health < 1;
    }
}