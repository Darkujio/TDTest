using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wave", menuName = "WaveData", order = 54)]
public class Wave : ScriptableObject
{
    [SerializeField] private Encounter[] Encounters;
    public Encounter[] GetEncounters
    {
        get
        {
            return Encounters;
        }
    }

    
}

[System.Serializable]
public class Encounter
{
    [SerializeField] public Enemies Enemy;
    [SerializeField] public int Amount;
}
