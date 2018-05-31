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
        CurrentPlayerTurn = PlayerTurn.FirstPlayerTurn;
        CurrentPhase = Phase.SelectionPhase;
    }

    public void OnPlayerTurnStart(PlayerTurn _currentPlayerTurn) {
        switch (_currentPlayerTurn)
        {
            case PlayerTurn.FirstPlayerTurn:
                break;
            case PlayerTurn.SecondPlayerTurn:
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
        if (CurrentPhase == Phase.PlacingPhase)
            CurrentPhase = Phase.SelectionPhase;
        else if (CurrentPhase == Phase.SelectionPhase)
            CurrentPhase = Phase.PlacingPhase;
    }

    public void SwitchPlayerTurn() {

    }
}

public enum PlayerTurn
{
    FirstPlayerTurn,
    SecondPlayerTurn
}

public enum Phase {
    SelectionPhase,
    PlacingPhase
}
