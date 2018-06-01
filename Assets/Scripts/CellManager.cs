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

public enum CellCoordinates {
    X_Y = 0,
    X0_Y0 = 1, X1_Y0 = 2, X2_Y0 = 3, X3_Y0 = 4,
    X0_Y1 = 5, X1_Y1 = 6, X2_Y1 = 7, X3_Y1 = 8,
    X0_Y2 = 9, X1_Y2 = 10, X2_Y2 = 11, X3_Y2 = 12,
    X0_Y3 = 13, X1_Y3 = 14, X2_Y3 = 15, X3_Y3 = 16
}
