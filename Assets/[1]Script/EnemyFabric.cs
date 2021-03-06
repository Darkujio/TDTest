using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class EnemyFabric : MonoBehaviour
{
    [SerializeField] LevelController LevelController;
    [SerializeField] Transform StartingPos;
    [SerializeField] Transform EnemiesParent;
    [SerializeField] LineRenderer LR;

    List<WaveEnemies> WavesEnemiesStorage;
    public Action EnemiesGenerated;
    public void Init()
    {
        List<Wave> Waves = LevelController.GetWaves();
        WavesEnemiesStorage = new List<WaveEnemies>();
        foreach (Wave wave in Waves)
        {
            WavesEnemiesStorage.Add(new WaveEnemies());
            WavesEnemiesStorage.Last().EnemiesInWave = new List<GameObject>();
            foreach (Encounter encounter in wave.GetEncounters)
            {
                for (int i = 0; i< encounter.Amount; i++)
                {
                    GameObject enemy = Instantiate(encounter.Enemy.EnemyPrefab,StartingPos.position,Quaternion.identity,EnemiesParent);
                    WavesEnemiesStorage.Last().EnemiesInWave.Add(enemy);
                    enemy.GetComponent<Enemy>().GetStartingInfo(encounter.Enemy, LR);
                    enemy.SetActive(false);
                }
            }
        }
        EnemiesGenerated?.Invoke();
    }

    public List<WaveEnemies> GetWavesEnemiesStorage()
    {
        return WavesEnemiesStorage;
    }
}
