using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Enemy : MonoBehaviour
{
    private LineRenderer LR;
    private int Health;
    private int Speed;
    private int Damage;

    protected Vector3[] Path;

    public Action OnDie;
    public Action OnReady;
    
    public void GetStartingInfo(Enemies ScObj)
    {
        Health = ScObj.GetHealth;
        Speed = ScObj.GetSpeed;
        Damage = ScObj.GetDamage;
        Path = GetPath();
        OnReady?.Invoke();
    }

    void ChangeHeath(int amount)
    {
        Health += amount;
        if (Health<1)
        {
            OnDie?.Invoke();
        }
    }

    Vector3[] GetPath()
    {
        Vector3[] positions = new Vector3[LR.positionCount];
        LR.GetPositions(positions);
        return positions;
    }
}
