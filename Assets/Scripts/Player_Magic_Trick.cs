using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Magic_Trick : MonoBehaviour
{
    private bool isKeyPressed;
    private MeshRenderer _renderer;
    private WaitForSeconds _waitTimeHide = new WaitForSeconds(5f);
    private WaitForSeconds _waitTimeColor = new WaitForSeconds(3f);
    
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        StartCoroutine(ChangeColorRoutine());                                  // Change object colour every 3 seconds
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && isKeyPressed == false)
        {
            isKeyPressed = true;
            _renderer.enabled = false;   // disable MashRenderer
            StartCoroutine(HideRoutine());
        }
    }
    IEnumerator HideRoutine()
    {
        yield return _waitTimeHide;
        _renderer.enabled = true;    // enable MashRenderer
        isKeyPressed = false;
    }
    IEnumerator ChangeColorRoutine()
    {
        while(true)
        {
        yield return _waitTimeColor;
        _renderer.material.color = NewColor();
        }
    }
    Color NewColor()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        return color;
    }


}
