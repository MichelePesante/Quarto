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

    public GameObject PawnPreview_3D;

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
        if (GameManager.isGamePaused == false)
        {
            if (PawnManager.Instance.hasPawnBeenSelected == false && !isPawnInGame && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
            {
                childParticleSystem.gameObject.SetActive(true);
                //PawnPreview();
                T_PawnPreview();
            }
        }
    }

    private void OnMouseDown()
    {
        if (GameManager.isGamePaused == false)
        {
            if (PawnManager.Instance.hasPawnBeenSelected == false && !isNowSelected && !isPawnInGame && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
            {
                SelectPawn();
                childParticleSystemMainModule.startColor = Color.green;
                //SwapPawnPreview();
                Swap_T_PawnPreview();
                TurnManager.Instance.SwitchPlayerTurn();
            }
        }
    }

    private void OnMouseExit()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && !isPawnInGame && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            childParticleSystem.gameObject.SetActive(false);
            //ResetPawnPreview();
            Reset_T_PawnPreview();
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

    public void ResetPawnPreview()
    {
        UIManager.Instance.Pawn_Preview_P2.color = new Color(1f, 1f, 1f, 0f);
        UIManager.Instance.Pawn_Preview_P1.color = new Color(1f, 1f, 1f, 0f);
    }

    public void SwapPawnPreview()
    {
        if (TurnManager.Instance.CurrentPlayerTurn == PlayerTurn.PlayerOne)
        {
            UIManager.Instance.Pawn_Preview_P2.sprite = UIManager.Instance.Pawn_Preview_P1.sprite;
            UIManager.Instance.Pawn_Preview_P2.color = UIManager.Instance.Pawn_Preview_P1.color;
            UIManager.Instance.Pawn_Preview_P1.color = new Color(1f, 1f, 1f, 0f);
        }
        else
        {
            UIManager.Instance.Pawn_Preview_P1.sprite = UIManager.Instance.Pawn_Preview_P2.sprite;
            UIManager.Instance.Pawn_Preview_P1.color = UIManager.Instance.Pawn_Preview_P2.color;
            UIManager.Instance.Pawn_Preview_P2.color = new Color(1f, 1f, 1f, 0f);
        }
    }

    public void T_PawnPreview()
    {
        if (TurnManager.Instance.CurrentPlayerTurn == PlayerTurn.PlayerOne)
        {
            PawnPreview_3D.transform.position = UIManager.Instance.T_Pawn_Preview_P2.position;
            PawnPreview_3D.transform.rotation = UIManager.Instance.T_Pawn_Preview_P2.rotation;
        }
        else
        {
            PawnPreview_3D.transform.position = UIManager.Instance.T_Pawn_Preview_P1.position;
            PawnPreview_3D.transform.rotation = UIManager.Instance.T_Pawn_Preview_P1.rotation;
        }
    }

    public void Reset_T_PawnPreview()
    {
        PawnPreview_3D.transform.localPosition = Vector3.zero;
        PawnPreview_3D.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
    }

    public void Swap_T_PawnPreview()
    {
        if (TurnManager.Instance.CurrentPlayerTurn == PlayerTurn.PlayerOne)
        {
            PawnPreview_3D.transform.position = UIManager.Instance.T_Pawn_Preview_P1.position;
            PawnPreview_3D.transform.rotation = UIManager.Instance.T_Pawn_Preview_P1.rotation;
        }
        else
        {
            PawnPreview_3D.transform.position = UIManager.Instance.T_Pawn_Preview_P2.position;
            PawnPreview_3D.transform.rotation = UIManager.Instance.T_Pawn_Preview_P2.rotation;
        }
    }

    #endregion
}