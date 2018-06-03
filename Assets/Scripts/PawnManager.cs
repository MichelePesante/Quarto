using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnManager : MonoBehaviour {

    public static PawnManager Instance;

    public bool hasPawnBeenSelected;

    public PawnController[] pawnsToAdd = new PawnController[16];

    public PawnController[] PawnsInGame = new PawnController[16];

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start () {
        for (int i = 0; i < pawnsToAdd.Length; i++) {
            pawnsToAdd[i] = FindObjectsOfType<PawnController>()[i];
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

    public void VictoryCheck(int firstVictoryIndex, int secondVictoryIndex, int thirdVictoryIndex, int fourthVictoryIndex, bool boolValue) {
        if (PawnsInGame[firstVictoryIndex] && PawnsInGame[secondVictoryIndex] && PawnsInGame[thirdVictoryIndex] && PawnsInGame[fourthVictoryIndex])
        {
            if (PawnsInGame[firstVictoryIndex].isCircle == boolValue && PawnsInGame[secondVictoryIndex].isCircle == boolValue && PawnsInGame[thirdVictoryIndex].isCircle == boolValue && PawnsInGame[fourthVictoryIndex].isCircle == boolValue)
            {
                PawnsInGame[firstVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[secondVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[thirdVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[fourthVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                if (boolValue == true)
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti rotondi!");
                else
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti quadrati!");
                GameManager.isGamePaused = true;
            }
            else if (PawnsInGame[firstVictoryIndex].isFilled == boolValue && PawnsInGame[secondVictoryIndex].isFilled == boolValue && PawnsInGame[thirdVictoryIndex].isFilled == boolValue && PawnsInGame[fourthVictoryIndex].isFilled == boolValue)
            {
                PawnsInGame[firstVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[secondVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[thirdVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[fourthVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                if (boolValue == true)
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti pieni!");
                else
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti bucati!");
                GameManager.isGamePaused = true;
            }
            else if (PawnsInGame[firstVictoryIndex].isSmall == boolValue && PawnsInGame[secondVictoryIndex].isSmall == boolValue && PawnsInGame[thirdVictoryIndex].isSmall == boolValue && PawnsInGame[fourthVictoryIndex].isSmall == boolValue)
            {
                PawnsInGame[firstVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[secondVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[thirdVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[fourthVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                if (boolValue == true)
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti bassi!");
                else
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti alti!");
                GameManager.isGamePaused = true;
            }
            else if (PawnsInGame[firstVictoryIndex].isWhite == boolValue && PawnsInGame[secondVictoryIndex].isWhite == boolValue && PawnsInGame[thirdVictoryIndex].isWhite == boolValue && PawnsInGame[fourthVictoryIndex].isWhite == boolValue)
            {
                PawnsInGame[firstVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[secondVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[thirdVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                PawnsInGame[fourthVictoryIndex].childParticleSystem.gameObject.SetActive(true);
                if (boolValue == true)
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti bianchi!");
                else
                    UIManager.Instance.SetAndShowVictoryText("Hai vinto, sono tutti neri!");
                GameManager.isGamePaused = true;
            }
        }
    }
}