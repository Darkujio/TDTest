using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    [SerializeField] Button Button;

    void Start()
    {
        Button.onClick.AddListener(CloseGame);
    }

    void CloseGame()
    {
        Application.Quit();
    }
}
