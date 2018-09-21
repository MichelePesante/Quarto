using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {

    private float distance = 2f;
    private float xSpeed = 90f;
    private bool rightclicked = false;
    private float x = 0f;

    void Start ()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            rightclicked = true;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            rightclicked = false;
        }
    }

    void LateUpdate()
    {
        if (rightclicked == true)
        {
            x += Input.GetAxis("Mouse X") * -xSpeed * distance * 0.02f;
            Quaternion rotation = Quaternion.Euler(0, x, 0);
            transform.rotation = rotation;
        }
    }

}
