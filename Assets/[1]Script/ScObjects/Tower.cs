using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower", menuName = "TowerData", order = 52)]
public class Tower : ScriptableObject
{
    [SerializeField] private int Damage;
    [SerializeField] private int Radius;
    [SerializeField] private int ShootInterval;
    [SerializeField] private int Price;

    public int GetDamage
    {
        get
        {
            return Damage;
        }
    }
    public int GetRadius
    {
        get
        {
            return Radius;
        }
    }
    public int GetShootInterval
    {
        get
        {
            return ShootInterval;
        }
    }
    public int GetPrice
    {
        get
        {
            return Price;
        }
    }
}
