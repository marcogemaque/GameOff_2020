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
        /* Welp, what else can you do? */

        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-5, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            transform.position += new Vector3(5, 0, 0);
        }
        else if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 5, 0);
        }
        else if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -5, 0);
        }
        else if (Input.GetKey("z")) //zoom out
        {
            transform.position += new Vector3(0, 0, 5);
        }
        else if (Input.GetKey("c"))
        {
            transform.position += new Vector3(0, 0, -5);
        }
    }
}