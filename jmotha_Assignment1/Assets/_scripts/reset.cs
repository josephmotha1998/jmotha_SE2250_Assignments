using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // varibale to store start position of object
    private Vector3 _startposition;
    private Vector3 _originalrotation;
    private Rigidbody _myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // stores start position
        _myrigidbody = GetComponent<Rigidbody>();
        _startposition = transform.position;
        _originalrotation = transform.eulerAngles;

        

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
            transform.position = _startposition;
            transform.eulerAngles = _originalrotation;
            _myrigidbody.velocity = Vector3.zero;
            _myrigidbody.angularVelocity = Vector3.zero;

        }
    }

}

