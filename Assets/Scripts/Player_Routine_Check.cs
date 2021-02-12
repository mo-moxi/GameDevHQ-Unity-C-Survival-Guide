using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Routine_Check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NameRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator  NameRoutine()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("My name is Hobo. Wait... ");
        yield return new WaitForSeconds(2f);
        Debug.Log("no... hang on... it's Flatulent Dog Buscuit!");
    }
}
