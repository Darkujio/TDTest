using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyOnTrigger : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    public Action<int> OnCastleAttack;
    int Damage;

    void Start()
    {
        Damage = enemy.GetDamage();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 9) 
        {
            Destroy(gameObject);
            OnCastleAttack?.Invoke(Damage);
        }
    }
}
