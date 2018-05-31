using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour {

    public static CellManager Instance;

    public CellController[] GeneralCells = new CellController[16];

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        for (int i = 0; i < GeneralCells.Length; i++)
        {
            GeneralCells[i] = FindObjectsOfType<CellController>()[i];
        }
    }

    void Update()
    {

    }
}
