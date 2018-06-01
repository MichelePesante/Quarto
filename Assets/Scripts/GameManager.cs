using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    void Update()
    {
        VictoryCondition();
    }

    private void VictoryCondition()
    {
        foreach (PawnController pawn in PawnManager.Instance.GeneralPawns)
        {
            if (pawn.PawnCoordinates == CellCoordinates.X0_Y0) {
                VictoryCheck(pawn, CellCoordinates.X0_Y1, CellCoordinates.X0_Y2, CellCoordinates.X0_Y3);
            }
            else if (pawn.PawnCoordinates == CellCoordinates.X3_Y0)
            {

            }
            else if (pawn.PawnCoordinates == CellCoordinates.X0_Y3)
            {

            }
            else if (pawn.PawnCoordinates == CellCoordinates.X3_Y0)
            {

            }
            else if (pawn.PawnCoordinates == CellCoordinates.X1_Y0)
            {

            }
            else if (pawn.PawnCoordinates == CellCoordinates.X2_Y0)
            {

            }
            else if (pawn.PawnCoordinates == CellCoordinates.X0_Y1)
            {

            }
            else if (pawn.PawnCoordinates == CellCoordinates.X0_Y2)
            {

            }
        }
    }

    private void VictoryCheck(PawnController firstVictoryPawn, CellCoordinates secondCoordinate, CellCoordinates thirdCoordinate, CellCoordinates fourthCoordinate)
    {
        PawnController secondVictoryPawn;
        PawnController thirdictoryPawn;
        PawnController fourthVictoryPawn;

        foreach (PawnController pawn in PawnManager.Instance.GeneralPawns)
        {
           if (pawn.PawnCoordinates == secondCoordinate && pawn)
            {
                secondVictoryPawn = pawn;
            }
            else if (pawn.PawnCoordinates == thirdCoordinate && pawn)
            {
                thirdictoryPawn = pawn;
            }
            else if (pawn.PawnCoordinates == fourthCoordinate && pawn)
            {
                fourthVictoryPawn = pawn;
            }
        }

        //if (firstVictoryPawn.isCircle == true && secondVictoryPawn.isCircle == true && thirdictoryPawn.isCircle == true && fourthVictoryPawn.isCircle == true) {
        //
        //}
    }

}