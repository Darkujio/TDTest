using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildState : MonoBehaviour
{
    [SerializeField] OnClick OnClick;
    [SerializeField] GameObject Towers;
    void Awake()
    {
        OnClick.Clicked += CheckMenu;
    }

    void CheckMenu()
    {
        if (Towers.activeSelf == false) BuildMenu();
        else ChangeMenu();
    }

    void BuildMenu()
    {
        print("WantToBuild");
    }

    void ChangeMenu()
    {
        print("WantToSell");
    }
}
