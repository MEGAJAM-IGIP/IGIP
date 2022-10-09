using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Waste", menuName = "Waste")]
public class WasteData : ScriptableObject
{
    public enum WasteType
    {
        Plastic,
        Paper,
        Styrofoam,
        Rubber,
        Cigarette,
        Glass
    };
    public string wasteName;
    public Sprite wasteSprite;
    public WasteType wasteType;

    [Header("waste move Speed")]
    public float minSpeed;
    public float maxSpeed;
}
 