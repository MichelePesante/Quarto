using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class CellController : MonoBehaviour {

    private bool isCellOccupied;

    private Outline childOutline;

    [SerializeField]
    public CellCoordinates cellCoordinate;

    void Start()
    {
        childOutline = GetComponentInChildren<Outline>();
    }

    void Update () {
		
	}

    private void OnMouseEnter()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase && !isCellOccupied)
        {
            childOutline.eraseRenderer = false;
            childOutline.color = 1;
        }
    }

    private void OnMouseDown()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase && !isCellOccupied)
        {
            childOutline.eraseRenderer = true;
            foreach (PawnController pawn in PawnManager.Instance.pawnToAdd)
            {
                if (pawn.isNowSelected) {
                    pawn.PlacePawn(this);
                    pawn.isNowSelected = false;
                }
            }
            TurnManager.Instance.SwitchPhase();
            isCellOccupied = true;
        }
    }

    private void OnMouseExit()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase && !isCellOccupied)
        {
            childOutline.eraseRenderer = true;
        }
    }

    public void ResetCellController ()
    {
        childOutline.eraseRenderer = true;
        childOutline.color = 0;
    }
}
