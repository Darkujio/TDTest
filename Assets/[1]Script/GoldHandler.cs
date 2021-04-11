using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoldHandler : MonoBehaviour
{
    public Action GoldChanged;
    [SerializeField] LevelController LevelController;
    [SerializeField] EnemyFabric EnemyFabric;
    int Gold;
    void Awake()
    {
        EnemyFabric.EnemiesGenerated +=  OnEnemyReady;
        Gold = LevelController.StartCoins();
        GoldChanged?.Invoke();
    }

    public int GetCurrentGold()
    {
        return Gold;
    }

    public void ChangeCurrentGold(int Value)
    {
        Gold += Value;
        GoldChanged?.Invoke();
    }

    void OnEnemyReady()
    {
        List<WaveEnemies> WaveEnemies = EnemyFabric.GetWavesEnemiesStorage();
        foreach (WaveEnemies Waves in WaveEnemies)
        {
            foreach(GameObject enemy in Waves.EnemiesInWave)
            {
                enemy.GetComponent<Enemy>().OnDie += GetGold;
            }
        }
    }

    void GetGold(int Min, int Max)
    {
        int Result = UnityEngine.Random.Range(Min,Max);
        print(Result);
        ChangeCurrentGold(Result);
    }
}
