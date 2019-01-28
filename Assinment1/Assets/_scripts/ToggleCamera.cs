using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCamera : MonoBehaviour
{
    //declare camera variables
    public Camera camera1;
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {
        // initiating camera 1 to be on
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if statement runs only when c key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            // statement to switch between cameras
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }

    }

    
}
