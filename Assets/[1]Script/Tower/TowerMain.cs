using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TowerMain : MonoBehaviour
{
    public Tower TowerSO;
    [SerializeField] SpriteRenderer SpriteRenderer;

    public int Radius;
    public int Damage;
    public float ShootInterval;
    public int Price;

    public Action StatsChanged;
    public Action ReadyToShoot;

    public void StartOnBuild()
    {
        Radius = TowerSO.GetRadius;
        Damage = TowerSO.GetDamage;
        ShootInterval = TowerSO.GetShootInterval;
        Price = TowerSO.GetPrice;
        
        StatsChanged?.Invoke();
        ReadyToShoot?.Invoke();


        SpriteRenderer.sprite = TowerSO.GetSprite;
    }
}
