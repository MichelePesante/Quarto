using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PawnProperties", menuName = "PawnData", order = 0)]
public class PawnData : ScriptableObject {

    public bool isCircle;
    public bool isFilled;
    public bool isSmall;
    public bool isWhite;
}
