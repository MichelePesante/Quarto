using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class CellController : MonoBehaviour {

    private bool isCellOccupied;

    private Outline childOutline;

    void Start()
    {
        childOutline = GetComponentInChildren<Outline>();
    }

    void Update () {
		
	}

    private void OnMouseEnter()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase)
        {
            childOutline.eraseRenderer = false;
            childOutline.color = 0;
        }
    }

    private void OnMouseDown()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase)
        {
            childOutline.color = 1;
            TurnManager.Instance.SwitchPhase();
        }
    }

    private void OnMouseExit()
    {
        if (TurnManager.Instance.CurrentPhase == Phase.PlacingPhase)
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
