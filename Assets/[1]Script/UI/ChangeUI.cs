using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUI : MonoBehaviour
{
    [SerializeField] SellUI SellUI;

    public void SetTower(GameObject tower)
    {
        SetSell(tower);
    }

    void SetSell(GameObject tower)
    {
        SellUI.SellData(tower);
    }
}
