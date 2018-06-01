using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnManager : MonoBehaviour {

    public static PawnManager Instance;

    public bool hasPawnBeenSelected;

    public PawnController[] pawnToAdd = new PawnController[16];

    public PawnController[] PawnsInGame = new PawnController[16];

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start () {
        for (int i = 0; i < pawnToAdd.Length; i++) {
            pawnToAdd[i] = FindObjectsOfType<PawnController>()[i];
        }
	}

	void Update () {
		
	}

    public void FillOrganizedArray(PawnController pawnToAdd) {
        if (pawnToAdd.PawnCoordinates == CellCoordinates.X0_Y0)
        {
            PawnsInGame[0] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X1_Y0)
        {
            PawnsInGame[1] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X2_Y0)
        {
            PawnsInGame[2] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X3_Y0)
        {
            PawnsInGame[3] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X0_Y1)
        {
        PawnsInGame[4] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X1_Y1)
        {
        PawnsInGame[5] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X2_Y1)
        {
        PawnsInGame[6] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X3_Y1)
        {
        PawnsInGame[7] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X0_Y2)
        {
        PawnsInGame[8] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X1_Y2)
        {
        PawnsInGame[9] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X2_Y2)
        {
        PawnsInGame[10] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X3_Y2)
        {
        PawnsInGame[11] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X0_Y3)
        {
        PawnsInGame[12] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X1_Y3)
        {
        PawnsInGame[13] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X2_Y3)
        {
        PawnsInGame[14] = pawnToAdd;
        }
        else if (pawnToAdd.PawnCoordinates == CellCoordinates.X3_Y3)
        {
        PawnsInGame[15] = pawnToAdd;
        }
    }
}