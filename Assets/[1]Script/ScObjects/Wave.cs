using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wave", menuName = "WaveData", order = 54)]
public class Wave : ScriptableObject
{
    [SerializeField] private Encounter[] Encounters;
    [Tooltip("Make it more than Interval * Amount of enemies")]public int WaveLength;
    public int Interval;
    public Encounter[] GetEncounters
    {
        get
        {
            return Encounters;
        }
    }

    
    
}
