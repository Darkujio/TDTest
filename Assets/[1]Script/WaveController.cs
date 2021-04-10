using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaveController : MonoBehaviour
{
    [SerializeField] LevelController LevelController;
    [SerializeField] EnemyFabric EnemyFabric;
    List<WaveEnemies> WavesEnemiesStorage;
    List<Wave> Waves;

    public Action<int> CurrentWaveForUI;

    void Awake()
    {
        EnemyFabric.EnemiesGenerated +=  FirstActivate;
    }

    void FirstActivate()
    {
        WavesEnemiesStorage = EnemyFabric.GetWavesEnemiesStorage();
        Waves = LevelController.GetWaves();
        Activator(0);
    }
    
    void Activator(int WaveNumber)
    {
        int i = 0;
        foreach(GameObject enemy in WavesEnemiesStorage[WaveNumber].EnemiesInWave)
        {
            i+= Waves[WaveNumber].Interval;
            StartCoroutine(Enemy(enemy,i));
        }
        CurrentWaveForUI?.Invoke(WaveNumber);
        if (WaveNumber+1 < WavesEnemiesStorage.Count) StartCoroutine(NextWave(WaveNumber));
    }

    IEnumerator Enemy(GameObject enemy, int PendTime)
    {
        yield return new WaitForSeconds(PendTime);
        enemy.SetActive(true);
    }

    IEnumerator NextWave(int WaveNumber)
    {
        int PendTime = Waves[WaveNumber].WaveLength;
        yield return new WaitForSeconds(PendTime);
        Activator(WaveNumber+1);
    }
}
