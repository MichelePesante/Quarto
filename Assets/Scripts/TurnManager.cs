using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public static TurnManager Instance;

    private PlayerTurn currentPlayerTurn;

    public PlayerTurn CurrentPlayerTurn { get { return currentPlayerTurn; } set { currentPlayerTurn = value; OnPlayerTurnStart(CurrentPlayerTurn); } }

    private Phase currentPhase;

    public Phase CurrentPhase { get { return currentPhase; } set { currentPhase = value; OnPhaseStart(CurrentPhase); } }

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        CurrentPlayerTurn = PlayerTurn.PlayerOne;
        CurrentPhase = Phase.SelectionPhase;
    }

    public void OnPlayerTurnStart(PlayerTurn _currentPlayerTurn) {
        switch (_currentPlayerTurn)
        {
            case PlayerTurn.PlayerOne:
                break;
            case PlayerTurn.PlayerTwo:
                break;
            default:
                break;
        }
    }

    public void OnPhaseStart(Phase _currentPhase) {
        switch (_currentPhase)
        {
            case Phase.SelectionPhase:
                break;
            case Phase.PlacingPhase:
                break;
            default:
                break;
        }
    }

    public void SwitchPhase() {
        if (CurrentPhase == Phase.SelectionPhase)
        {
            foreach (CellController cell in CellManager.Instance.GeneralCells)
            {
                cell.ResetCellController();
            }

            CurrentPhase = Phase.PlacingPhase;
           
        }
        else if (CurrentPhase == Phase.PlacingPhase)
        {
            foreach (PawnController pawn in PawnManager.Instance.pawnsToAdd)
            {
                pawn.ResetPawnController();
            }

            foreach (CellController cell in CellManager.Instance.GeneralCells)
            {
                cell.ResetCellController();
            }

            CurrentPhase = Phase.PlacingPhase;

            CurrentPhase = Phase.SelectionPhase;
        }
    }

    public void SwitchPlayerTurn()
    {
        if (CurrentPlayerTurn == PlayerTurn.PlayerOne)
        {
            CurrentPlayerTurn = PlayerTurn.PlayerTwo;
        }
        else
        {
            CurrentPlayerTurn = PlayerTurn.PlayerOne;
        }
    }
}

public enum PlayerTurn
{
    PlayerOne,
    PlayerTwo
}

public enum Phase
{
    SelectionPhase,
    PlacingPhase
}
