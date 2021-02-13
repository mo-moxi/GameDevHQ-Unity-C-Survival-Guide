using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int id;
    public string name;

    public static int connectionCount;

    public Player()
    {
        connectionCount ++;
    }
}


public class Player_Login : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();
        Player p4 = new Player();

        Debug.Log("Connect plaers: " + Player.connectionCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
