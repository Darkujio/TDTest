using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using System;

public class Enemy : MonoBehaviour
{
    private LineRenderer LR;
    protected int Health;
    public int Speed;
    protected int Damage;

    public List<Vector3> Path;

    public Action OnDie;
    public Action OnReady;
    
    public void GetStartingInfo(Enemies ScObj, LineRenderer lr)
    {
        LR = lr;
        Health = ScObj.GetHealth;
        Speed = ScObj.GetSpeed;
        Damage = ScObj.GetDamage;
        Path = GetPath();
        OnReady?.Invoke();
    }

    public void ChangeHealth(int amount)
    {
        Health += amount;
        if (Health<1)
        {
            Destroy(gameObject);
            OnDie?.Invoke();
        }
    }

    List<Vector3> GetPath()
    {
        Vector3[] positions = new Vector3[LR.positionCount];
        LR.GetPositions(positions);
        List<Vector3> PositionList = positions.ToList();
        return PositionList;
    }

    public int GetDamage()
    {
        return Damage;
    }
}
