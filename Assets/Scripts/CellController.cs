using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour {

    private bool isCellOccupied;

    private Color StartingEmissionValue;
    private Color HighlightedEmissionValue;

    private Material childMaterial;

    [SerializeField]
    public CellCoordinates cellCoordinate;

    void Start()
    {
        childMaterial = GetComponentInChildren<Renderer>().material;
        HighlightedEmissionValue = Color.white;
        StartingEmissionValue = HighlightedEmissionValue * Mathf.LinearToGammaSpace(0f);
    }

    void Update () {
		
	}

    private void OnMouseEnter()
    {
        if (GameManager.isGamePaused == false)
        {
            if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase && !isCellOccupied)
            {
                HighlightCell();
            }
        }
    }

    private void OnMouseDown()
    {
        if (GameManager.isGamePaused == false)
        {
            if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase && !isCellOccupied)
            {
                TurnManager.Instance.SwitchPhase();
                foreach (PawnController pawn in PawnManager.Instance.pawnsToAdd)
                {
                    if (pawn.isNowSelected)
                    {
                        pawn.PlacePawn(this);
                        pawn.isNowSelected = false;
                    }
                }
                isCellOccupied = true;
            }
        }
    }

    private void OnMouseExit()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase && !isCellOccupied)
        {
            childMaterial.SetColor("_EmissionColor", StartingEmissionValue);
        }
    }

    public void ResetCellController ()
    {
        childMaterial.SetColor("_EmissionColor", StartingEmissionValue);
    }

    public void HighlightCell() {
        childMaterial.SetColor("_EmissionColor", HighlightedEmissionValue);
    }
}
