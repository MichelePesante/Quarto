using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private PawnController FirstVictoryPawn;
    private PawnController SecondVictoryPawn;
    private PawnController ThirdVictoryPawn;
    private PawnController FourthVictoryPawn;

    void Update()
    {
        VictoryCondition(CellCoordinates.X0_Y0, CellCoordinates.X0_Y1, CellCoordinates.X0_Y2, CellCoordinates.X0_Y3);
        VictoryCondition(CellCoordinates.X1_Y0, CellCoordinates.X1_Y1, CellCoordinates.X1_Y2, CellCoordinates.X1_Y3);
        VictoryCondition(CellCoordinates.X2_Y0, CellCoordinates.X2_Y1, CellCoordinates.X2_Y2, CellCoordinates.X2_Y3);
        VictoryCondition(CellCoordinates.X3_Y0, CellCoordinates.X3_Y1, CellCoordinates.X3_Y2, CellCoordinates.X3_Y3);
        VictoryCondition(CellCoordinates.X0_Y0, CellCoordinates.X1_Y0, CellCoordinates.X2_Y0, CellCoordinates.X3_Y0);
        VictoryCondition(CellCoordinates.X0_Y1, CellCoordinates.X1_Y1, CellCoordinates.X2_Y1, CellCoordinates.X3_Y1);
        VictoryCondition(CellCoordinates.X0_Y2, CellCoordinates.X1_Y2, CellCoordinates.X2_Y2, CellCoordinates.X3_Y2);
        VictoryCondition(CellCoordinates.X0_Y3, CellCoordinates.X1_Y3, CellCoordinates.X2_Y3, CellCoordinates.X3_Y3);
        VictoryCondition(CellCoordinates.X0_Y0, CellCoordinates.X1_Y1, CellCoordinates.X2_Y2, CellCoordinates.X3_Y3);
        VictoryCondition(CellCoordinates.X3_Y0, CellCoordinates.X2_Y1, CellCoordinates.X1_Y2, CellCoordinates.X0_Y3);
    }

    private void VictoryCondition(CellCoordinates firstCoordinate, CellCoordinates secondCoordinate, CellCoordinates thirdCoordinate, CellCoordinates fourthCoordinate)
    {
        foreach (PawnController pawn in PawnManager.Instance.GeneralPawns)
        {
            if (pawn.PawnCoordinates == firstCoordinate) {
                FirstVictoryPawn = pawn;
            }
            else if (pawn.PawnCoordinates == secondCoordinate)
            {
                SecondVictoryPawn = pawn;
            }
            else if (pawn.PawnCoordinates == thirdCoordinate)
            {
                ThirdVictoryPawn = pawn;
            }
            else if (pawn.PawnCoordinates == fourthCoordinate)
            {
                FourthVictoryPawn = pawn;
            }
        }
        VictoryCheck(true);
        VictoryCheck(false);
    }

    private void VictoryCheck(bool boolValue)
    {
        if (FirstVictoryPawn && SecondVictoryPawn && ThirdVictoryPawn && FourthVictoryPawn)
        {
            if (FirstVictoryPawn.isCircle == boolValue && SecondVictoryPawn.isCircle == boolValue && ThirdVictoryPawn.isCircle == boolValue && FourthVictoryPawn.isCircle == boolValue)
            {
                print("Hai vinto!");
            }
            else if (FirstVictoryPawn.isFilled == boolValue && SecondVictoryPawn.isFilled == boolValue && ThirdVictoryPawn.isFilled == boolValue && FourthVictoryPawn.isFilled == boolValue)
            {
                print("Hai vinto!");
            }
            else if (FirstVictoryPawn.isSmall == boolValue && SecondVictoryPawn.isSmall == boolValue && ThirdVictoryPawn.isSmall == boolValue && FourthVictoryPawn.isSmall == boolValue)
            {
                print("Hai vinto!");
            }
            else if (FirstVictoryPawn.isWhite == boolValue && SecondVictoryPawn.isWhite == boolValue && ThirdVictoryPawn.isWhite == boolValue && FourthVictoryPawn.isWhite == boolValue)
            {
                print("Hai vinto!");
            }
        }
    }

}