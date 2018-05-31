using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class PawnController : MonoBehaviour {

    private MeshRenderer childMeshRenderer;
    private Outline childOutline;

	// Use this for initialization
	void Start () {
        childMeshRenderer = GetComponentInChildren<MeshRenderer>();
        childOutline = GetComponentInChildren<Outline>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnMouseEnter()
    {
        childOutline.eraseRenderer = false;
    }

    private void OnMouseExit()
    {
        childOutline.eraseRenderer = true;
    }
}
