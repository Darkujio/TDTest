using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private int Lives;
    [SerializeField] private int Start_Coins;
    [SerializeField] private int CurrentWave;
    [SerializeField] private List<Wave> Waves;
    public List<WaveEnemies> WavesEnemiesStorage;
    public List<Wave> GetWaves()
    {
        return Waves;
    }
}
