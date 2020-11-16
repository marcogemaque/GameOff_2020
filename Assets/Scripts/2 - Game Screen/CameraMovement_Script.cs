using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement_Script : MonoBehaviour
{

    public Vector3 startVec;

    public void Start()
    {
        startVec = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-5, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(5, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 5, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -5, 0);
        }
    }
}