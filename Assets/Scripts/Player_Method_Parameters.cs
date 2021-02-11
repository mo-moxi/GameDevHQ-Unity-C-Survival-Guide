using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Method_Parameters : MonoBehaviour
{
    // Methods use Pascal Casing
    // Variables use Camel casing
    public int health;
    void Start()
    {
            Sum(5, 2);
            health = Random.Range(0, 100);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(Random.Range(0, 50));
        }
    }
    private void Attack()
    {
        //All Attack code here.
    }
    private void Powerup()
    {
        //All powerups code here
    }
    private void Shoot()
    {
        //All shooting code here
    }

    // Maths
    private void Sum(int a, int b)
    {
        Debug.Log(a + b);
    }
    // Player damage

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Damage: "+damageAmount);
        if (health < 1)
            health = 0;
            Debug.Log("You died!");
            Destroy(this.gameObject);
    }
    
}
