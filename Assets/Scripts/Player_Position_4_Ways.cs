using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Position_4_Ways : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        // basic transform
        // transform.position = new Vector3(0,0,0);

        // Using custom function
        // without parameters
        // ChangePosition();
        
        // with parameters
        // ChangePosition(new Vector3(0,0,0));

        // return type
        transform.position = GetPosition(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangePosition(Vector3 pos)
    {
        // transform.position = Vector3.zero; // public void ChangePosition()
        // transform.position = pos;          // public void ChangePosition(Vector3 pos)
    }   
    public Vector3 GetPosition(float x,float y,float z)

    {
        // return Vector3.zero;                  // public Vector3 GetPosition()
        // return new Vector3(x, y, z);
        Vector3 pos = new Vector3(x, y, z);

        return pos;
    }
}
