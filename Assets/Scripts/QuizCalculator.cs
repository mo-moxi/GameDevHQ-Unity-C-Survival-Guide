using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    // Challenge:
    // Create five (5) quiz grade
    // Assign a random value to each grade
    // Calculate the quiz average.

    public float[] quiz = new float[5];
    public float gradeTotal;
    public float gradeAverage;
    void Start()
    {
        float average;
        for (int i = 0; i < quiz.Length; i++)
        {
            quiz[i] = Random.Range(0f, 100f);

            gradeTotal = gradeTotal + quiz[i];
        }
        gradeAverage = Mathf.Round((gradeTotal / quiz.Length) * 100f) / 100f;
        Debug.Log("Average: " + gradeAverage);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
