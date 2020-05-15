using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private string _pattern = "{0} /15";
    [SerializeField] private Text _display;

    public void Display(int value)
    {
        _display.text = string.Format(_pattern, value);
    }
}
