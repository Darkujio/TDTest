using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellUI : MonoBehaviour
{
    [SerializeField] Button Button;
    [SerializeField] GoldHandler GoldHandler;
    [SerializeField] TextMeshProUGUI SellPriceText;
    [SerializeField] GameObject ChangeUI;
    
    Tower TowerSO;
    GameObject SelectedTower;
    int SellPrice;
    public void SellData(GameObject tower)
    {
        SelectedTower = tower;
        TowerSO = SelectedTower.GetComponent<TowerMain>().TowerSO;
        SellPrice = TowerSO.GetPrice;
        SellPriceText.SetText(SellPrice.ToString());
    }

    void Start()
    {
        Button.onClick.AddListener(SellTower);
    }

    void SellTower()
    {
        GoldHandler.ChangeCurrentGold(SellPrice);
        SelectedTower.SetActive(false);
        ChangeUI.SetActive(false);
    }
}
