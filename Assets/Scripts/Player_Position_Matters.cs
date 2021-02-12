using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Position_Matters : MonoBehaviour
{
    // Challenge
    // create and array of 5 different positions and use a custom method to
    // generate a random index, then use a custom method to set the position
    // to that sub index

    public Vector3[] positions;
    private int _randomIndex;

    void Start()
    {
        positions = SetPositions();                 // start populate methos
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))         // change position when space key is pressed    
        {
            _randomIndex = SetRandom();
            transform.position = ChangePositions();
        }
    }
    public Vector3[] SetPositions()                 // populate the positions array
    {
        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = new Vector3(Random.Range(-4, 4),Random.Range(-3, 4),Random.Range(-3, 3));
        }
        return positions;
    }
     public Vector3 ChangePositions()               // return the index position
    {
        Vector3 pos = positions[_randomIndex];
        return pos;
    }
    public int SetRandom()                          // generate random index position
    {
        return Random.Range(0, positions.Length);
    }
}
