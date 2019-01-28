using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeangle : MonoBehaviour
{
    // move speed
    public float movespeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseOver();
    }
    // function to tell if the mouse id is over the object
    private void OnMouseOver()
    {
        // if statement to tell when the left mouse is clicked
        if (Input.GetMouseButtonUp(0))
        {
            // inbuilt functions that mulitples th move speed by the time to rotate
            transform.Rotate(Vector3.right, movespeed * Time.deltaTime);
        }
    }
}
