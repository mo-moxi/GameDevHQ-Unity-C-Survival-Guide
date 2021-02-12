using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer[] Customer;
    
    [SerializeField]
    Customer jon;
    [SerializeField]
    Customer sam;
    [SerializeField]
    Customer lilly;

    void Start()
    {
        jon = new Customer("Jon", "Little", 42, "M", "Hobo");
        sam = new Customer("Sam", "Small", 22, "F", "Musician");
        lilly = new Customer("Lilly", "Petite", 12, "f", "Student");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
