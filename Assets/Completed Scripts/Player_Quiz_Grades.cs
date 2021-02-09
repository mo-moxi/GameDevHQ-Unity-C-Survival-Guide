using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Quiz_Grades : MonoBehaviour
{
    //Challenge
    // Create 5 random quiz grades
    // Calculate the average quiz grades
    // that prints out the grade average base don this scenario

    // Print A >= 90;
    // Print B >= 80 but < 90
    // Print C >= 70 but < 80
    // Print F < 70    
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float gradeAverage;
    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(70f, 100f);                // increased base value to 70 to force higher average
        quiz2 = Random.Range(70f, 100f);
        quiz3 = Random.Range(70f, 100f);
        quiz4 = Random.Range(70f, 100f);
        quiz5 = Random.Range(70f, 100f);

        gradeAverage = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (gradeAverage >= 90)
        {
            Debug.Log("Your average grade is A");
        }
        else if (gradeAverage >= 80 && gradeAverage < 90)
        {
            Debug.Log("Your average grade is B");
        }
        else if (gradeAverage >= 70 && gradeAverage < 80)
        {
            Debug.Log("Your average grade is C");
        }
        else
        {
            Debug.Log("Your average grade is F");
        }
    }
}
