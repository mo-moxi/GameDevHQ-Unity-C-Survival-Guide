using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Magic_Trick : MonoBehaviour
{
    private bool isKeyPressed;
    void Start()
    {
        ChangeColor();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && isKeyPressed == false)
        {
            ChangeColor();
            StartCoroutine(HideCube());
        }
    }
    IEnumerator HideCube()
    {
        isKeyPressed = true;
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(5f);
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        isKeyPressed = false;
    }
    public void ChangeColor()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f );
    }


}
