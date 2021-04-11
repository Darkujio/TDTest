using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGold : MonoBehaviour
{
    [SerializeField]GoldHandler GoldHandler;
    [SerializeField]TextMeshProUGUI GoldText;
    void Awake()
    {
        GoldHandler.GoldChanged+= GoldChanged;
    }

    void GoldChanged()
    {
        GoldText.SetText(GoldHandler.GetCurrentGold().ToString());
    }
}
