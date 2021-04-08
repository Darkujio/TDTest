using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Encounter
{
    [SerializeField] public Enemies Enemy;
    [SerializeField] public int Amount;
}

public class WaveEnemies
{
    public List<GameObject> EnemiesInWave;
}
