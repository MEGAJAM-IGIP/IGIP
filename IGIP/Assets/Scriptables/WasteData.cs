using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Waste", menuName = "Waste")]
public class WasteData : ScriptableObject
{
    public string wasteName;
    public AudioClip wasteSound;
    public int score;

    [Header("waste move Speed")]
    public float minSpeed;
    public float maxSpeed;
}
 