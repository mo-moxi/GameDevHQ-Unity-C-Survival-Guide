using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public static int enemyCount;
    
    void Start()
    {
        
    }

    void Update()
    {
    if(Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }        
    }
}
