using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    void Update()
    {
        for (int i = 0; i < PawnManager.Instance.GeneralPawns.Length; i++)
        {
            if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X0_Y0)
            {
                PawnManager.Instance.PawnsInGame[0] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X1_Y0)
            {
                PawnManager.Instance.PawnsInGame[1] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X2_Y0)
            {
                PawnManager.Instance.PawnsInGame[2] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X3_Y0)
            {
                PawnManager.Instance.PawnsInGame[3] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X0_Y1)
            {
                PawnManager.Instance.PawnsInGame[4] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X1_Y1)
            {
                PawnManager.Instance.PawnsInGame[5] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X2_Y1)
            {
                PawnManager.Instance.PawnsInGame[6] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X3_Y1)
            {
                PawnManager.Instance.PawnsInGame[7] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X0_Y2)
            {
                PawnManager.Instance.PawnsInGame[8] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X1_Y2)
            {
                PawnManager.Instance.PawnsInGame[9] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X2_Y2)
            {
                PawnManager.Instance.PawnsInGame[10] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X3_Y2)
            {
                PawnManager.Instance.PawnsInGame[11] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X0_Y3)
            {
                PawnManager.Instance.PawnsInGame[12] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X1_Y3)
            {
                PawnManager.Instance.PawnsInGame[13] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X2_Y3)
            {
                PawnManager.Instance.PawnsInGame[14] = PawnManager.Instance.GeneralPawns[i];
            }
            else if (PawnManager.Instance.GeneralPawns[i].PawnCoordinates == CellCoordinates.X3_Y3)
            {
                PawnManager.Instance.PawnsInGame[15] = PawnManager.Instance.GeneralPawns[i];
            }
        }
    }


}