using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] Button ExitButton;

    void Start()
    {
        ExitButton.onClick.AddListener(CloseGame);
    }

    void CloseGame()
    {
        Application.Quit();
    }
}
