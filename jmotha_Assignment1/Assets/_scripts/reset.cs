using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // varibale to store start position of object
    Vector3 startposition;
    Vector3 originalrotation;

    // Start is called before the first frame update
    void Start()
    {
        // stores start position
        startposition = transform.position;
        originalrotation = transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {

    }
    // in built function to run only when the mouse is over the object
    private void OnMouseOver()
    {
        //if statement to run only if left mouse button is clicked
        if (Input.GetMouseButtonUp(1))
        {
            //sets position to original start position
            transform.position = startposition;
            transform.eulerAngles = originalrotation;

        }
    }

}

