using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LifeHandler : MonoBehaviour
{
    [SerializeField] LevelController LevelController;
    [SerializeField] EnemyFabric EnemyFabric;
    private int Lives;

    public Action OnLivesChange;

    void Awake()
    {
        EnemyFabric.EnemiesGenerated += Init;
    }

    void Init()
    {
        Lives = LevelController.GetLifes();
        foreach (WaveEnemies Wave in EnemyFabric.GetWavesEnemiesStorage())
        {
            foreach (GameObject enemy in Wave.EnemiesInWave)
            {
                enemy.GetComponent<EnemyOnTrigger>().OnCastleAttack += ChangeLife;
            }
        }
    }

    void ChangeLife(int Damage)
    {
        Lives -= Damage;
        OnLivesChange?.Invoke();
    }

    public int GetCurrentLives()
    {
        return Lives;
    }
}
