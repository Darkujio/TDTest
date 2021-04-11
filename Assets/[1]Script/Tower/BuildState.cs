using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildState : MonoBehaviour
{
    [SerializeField] OnClick OnClick;
    [SerializeField] GameObject Tower;
    [SerializeField] TowerUI TowerUI;
    void Awake()
    {
        OnClick.Clicked += CheckMenu;
    }

    void CheckMenu()
    {
        StartCoroutine(CheckMenuClock());
    }

    void BuildMenu()
    {
        TowerUI.ActivateUI(Tower);
    }

    void ChangeMenu()
    {
        TowerUI.ChangeUI(Tower);
    }

    IEnumerator CheckMenuClock()
    {
        yield return new WaitForSeconds(0.03f);
        TowerUI.gameObject.transform.position = transform.position;
        if (Tower.activeSelf == false) BuildMenu();
        else ChangeMenu();
    }
}
