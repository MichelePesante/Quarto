using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour {

    public PawnData PawnProperty;

    public CellCoordinates PawnCoordinates;

    [Header ("Proprietà Pedina")]
    public bool isCircle;
    public bool isFilled;
    public bool isSmall;
    public bool isWhite;

    public bool isPawnInGame;

    public bool isNowSelected;

    public bool isPawnVictory;

    private ParticleSystem.MainModule childParticleSystemMainModule;

    public ParticleSystem childParticleSystem;

	void Start () {
        childParticleSystem = GetComponentInChildren<ParticleSystem>();
        childParticleSystemMainModule = childParticleSystem.main;
        childParticleSystem.gameObject.SetActive(false);
        Setup();
	}
	
	void Update () {

	}

    private void OnMouseEnter()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && !isPawnInGame && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            childParticleSystem.gameObject.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && !isNowSelected && !isPawnInGame && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            SelectPawn();
            childParticleSystemMainModule.startColor = Color.green;
        }
    }

    private void OnMouseExit()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && !isPawnInGame && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            childParticleSystem.gameObject.SetActive(false);
        }
    }

    private void Setup() {
        isCircle = PawnProperty.isCircle;
        isFilled = PawnProperty.isFilled;
        isSmall = PawnProperty.isSmall;
        isWhite = PawnProperty.isWhite;
    }

    #region API

    public void SelectPawn()
    {
        PawnManager.Instance.hasPawnBeenSelected = true;
        isNowSelected = true;
        isPawnInGame = true;
        TurnManager.Instance.SwitchPhase();
    }

    public PawnController GetSelectedPawn(PawnController pawnToReturn) {
        return pawnToReturn;
    }

    public void PlacePawn(CellController cellToPlaceOn) {
        transform.position = cellToPlaceOn.transform.position;
        PawnCoordinates = cellToPlaceOn.cellCoordinate;
        PawnManager.Instance.FillOrganizedArray(this);
        PawnManager.Instance.VictoryCheck(0, 1, 2, 3, true);
        PawnManager.Instance.VictoryCheck(0, 1, 2, 3, false);
        PawnManager.Instance.VictoryCheck(0, 4, 8, 12, true);
        PawnManager.Instance.VictoryCheck(0, 4, 8, 12, false);
        PawnManager.Instance.VictoryCheck(0, 5, 10, 15, true);
        PawnManager.Instance.VictoryCheck(0, 5, 10, 15, false);
        PawnManager.Instance.VictoryCheck(1, 5, 9, 13, true);
        PawnManager.Instance.VictoryCheck(1, 5, 9, 13, false);
        PawnManager.Instance.VictoryCheck(2, 6, 10, 14, true);
        PawnManager.Instance.VictoryCheck(2, 6, 10, 14, false);
        PawnManager.Instance.VictoryCheck(3, 6, 9, 12, true);
        PawnManager.Instance.VictoryCheck(3, 6, 9, 12, false);
        PawnManager.Instance.VictoryCheck(3, 7, 11, 15, true);
        PawnManager.Instance.VictoryCheck(3, 7, 11, 15, false);
        PawnManager.Instance.VictoryCheck(4, 5, 6, 7, true);
        PawnManager.Instance.VictoryCheck(4, 5, 6, 7, false);
        PawnManager.Instance.VictoryCheck(8, 9, 10, 11, true);
        PawnManager.Instance.VictoryCheck(8, 9, 10, 11, false);
        PawnManager.Instance.VictoryCheck(12, 13, 14, 15, true);
        PawnManager.Instance.VictoryCheck(12, 13, 14, 15, false);
    }

    public void ResetPawnController()
    {
        childParticleSystem.gameObject.SetActive(false);
        PawnManager.Instance.hasPawnBeenSelected = false;
    }

    #endregion
}