using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class PawnController : MonoBehaviour { 

    private Outline childOutline;

	void Start () {
        childOutline = GetComponentInChildren<Outline>();
	}
	
	void Update () {

	}

    private void OnMouseEnter()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            childOutline.eraseRenderer = false;
            childOutline.color = 0;
        }
    }

    private void OnMouseDown()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            SelectPawn();
            childOutline.color = 1;
        }
    }

    private void OnMouseExit()
    {
        if (PawnManager.Instance.hasPawnBeenSelected == false && TurnManager.Instance.CurrentPhase == Phase.SelectionPhase)
        {
            childOutline.eraseRenderer = true;
        }
    }

    #region API

    public void SelectPawn()
    {
        PawnManager.Instance.hasPawnBeenSelected = true;
        TurnManager.Instance.SwitchPhase();
    }

    public PawnController GetSelectedPawn(PawnController pawnToReturn) {
        return pawnToReturn;
    }

    public void ResetPawnController()
    {
        childOutline.eraseRenderer = true;
        childOutline.color = 0;
        PawnManager.Instance.hasPawnBeenSelected = false;
    }

    #endregion
}