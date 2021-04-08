using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemyData", order = 53)]
public class Enemies : ScriptableObject
{
    [SerializeField] private int Health;
    [SerializeField] private int Speed;
    [SerializeField] private int Damage;
    [SerializeField] public GameObject EnemyPrefab;

    public int GetHealth
    {
        get
        {
            return Health;
        }
    }
    public int GetSpeed
    {
        get
        {
            return Speed;
        }
    }
    public int GetDamage
    {
        get
        {
            return Damage;
        }
    }
}
