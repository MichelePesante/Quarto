using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private RotationController cameraAnchor;

    void Start()
    {
        cameraAnchor = FindObjectOfType<RotationController>();
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(cameraAnchor.gameObject.transform);
	}
}
