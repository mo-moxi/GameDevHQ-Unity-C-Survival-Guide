using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Speed_Increment : MonoBehaviour
{
    public int speed;
    public int maxSpeed;
    //Challenge
    //Create a program where the value of speed is incremented by 5 per second 
    //When speed is greater than maxSpeed, stop incrementing

    //Start is called before the first frame update
    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(IncreaseSpeedRoutine());
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator IncreaseSpeedRoutine()
    {
        /*  for (int i = 0; speed < maxSpeed; i++)
            {
                yield return new WaitForSeconds(1f);
                speed += 5;
            }
        */
        while (speed < maxSpeed)                    // altrrnative: while(true)
        {
            yield return new WaitForSeconds(1f);
            speed += 5;                             // alternative: if(speed < maxSpeed)
                                                    //                 {break;}
        }
        /*
        do
        {
            yield return new WaitForSeconds(1f);
            speed += 5; 
        }while (speed < maxSpeed)
        */
    }
}
