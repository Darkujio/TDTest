using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TotalWaves;
    [SerializeField] TextMeshProUGUI CurrentWave;
    [SerializeField] WaveController WaveController;
    [SerializeField] LevelController LevelController;

    void Awake()
    {
        WaveController.CurrentWaveForUI += SetWave;
        TotalWaves.SetText(LevelController.GetWavesAmount().ToString());
    }
    
    void SetWave(int WaveNumber)
    {
        CurrentWave.SetText((WaveNumber+1).ToString());
    }
}
