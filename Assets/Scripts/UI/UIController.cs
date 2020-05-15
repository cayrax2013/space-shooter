using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private LoseWindow _loseWindow;
    [SerializeField] private WinWindow _winWindow;

    public void OpenLoseWindow()
    {
        _loseWindow.Open();
    }

    public void OpenWinWindow()
    {
        _winWindow.Open();
    }
}
