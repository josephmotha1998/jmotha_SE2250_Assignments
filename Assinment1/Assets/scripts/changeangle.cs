using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeangle : MonoBehaviour
{
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
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.Rotate(Vector3.right, movespeed * Time.deltaTime);
        }
    }
}
