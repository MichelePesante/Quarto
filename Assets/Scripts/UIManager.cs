using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour {

    public static UIManager Instance;

    public Image Pawn_Preview_P1;
    public Image Pawn_Preview_P2;

    public Transform T_Pawn_Preview_P1;
    public Transform T_Pawn_Preview_P2;

    private TextMeshProUGUI Victory_Text;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start () {
        Victory_Text = FindObjectOfType<TextMeshProUGUI>();
        Victory_Text.gameObject.SetActive(false);
    }

    public void SetAndShowVictoryText(string textToShow) {
        Victory_Text.text = textToShow;
        Victory_Text.gameObject.SetActive(true);
    }
}
