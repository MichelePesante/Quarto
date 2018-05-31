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
    X_Y,
    X0_Y0, X1_Y0, X2_Y0, X3_Y0,
    X0_Y1, X1_Y1, X2_Y1, X3_Y1,
    X0_Y2, X1_Y2, X2_Y2, X3_Y2,
    X0_Y3, X1_Y3, X2_Y3, X3_Y3
}
