using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUI : MonoBehaviour
{
    [SerializeField] GameObject BuildUI;
    [SerializeField] GameObject Change;
    public void ActivateUI(GameObject TargetTower)
    {
        BuildUI.SetActive(true);
        foreach(Transform Tower in BuildUI.transform)
        {
            Tower.gameObject.GetComponent<SingleTowerUI>().tower = TargetTower;
        }
    }

    public void ChangeUI(GameObject tower)
    {
        Change.SetActive(true);
        Change.GetComponent<ChangeUI>().SetTower(tower);
    }
}
