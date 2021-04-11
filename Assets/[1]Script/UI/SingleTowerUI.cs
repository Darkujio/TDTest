using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SingleTowerUI : MonoBehaviour
{
    [SerializeField] Button Button;
    [HideInInspector] public GameObject tower;
    [SerializeField] Tower TowerSO;
    [SerializeField] GoldHandler GoldHandler;
    [SerializeField] GameObject BuildUI;
    [SerializeField] TextMeshProUGUI Price;
    int TowerPrice;

    void Awake()
    {
        Button.onClick.AddListener(PokeTower);
        TowerPrice = TowerSO.GetPrice;
        Price.SetText(TowerPrice.ToString());
    }

    void PokeTower()
    {
        int CurrentGold = GoldHandler.GetCurrentGold();
        if (CurrentGold >= TowerPrice)
        {
            GoldHandler.ChangeCurrentGold(-TowerPrice);
            CreateTower();
            BuildUI.SetActive(false);
        }
    }

    void CreateTower()
    {
        tower.GetComponent<TowerMain>().TowerSO = TowerSO;
        tower.SetActive(true);
        tower.GetComponent<TowerMain>().StartOnBuild();
    }
}
