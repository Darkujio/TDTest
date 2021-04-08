using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesCounter : MonoBehaviour
{
    [SerializeField]LifeHandler LifeHandler;
    [SerializeField]TextMeshProUGUI LivesText;
    void Start()
    {
        LifeHandler.OnLivesChange += LivesChanged;
    }

    void LivesChanged()
    {
        LivesText.SetText(LifeHandler.GetCurrentLives().ToString());
    }
}
