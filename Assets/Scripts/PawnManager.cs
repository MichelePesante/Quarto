using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnManager : MonoBehaviour {

    public static PawnManager Instance;

    public delegate void OnPawnSelection();
    public delegate void OnPawnPlace();

    public bool hasPawnBeenSelected;

    public PawnController[] GeneralPawns = new PawnController[16];

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start () {
        for (int i = 0; i < GeneralPawns.Length; i++) {
            GeneralPawns[i] = FindObjectsOfType<PawnController>()[i];
        }
	}

	void Update () {
		
	}
}