using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarHandler : MonoBehaviour
{
    [SerializeField] private Image _healthbar;

    public void DisplayHealthbar(int value)
    {
        _healthbar.fillAmount = value * 0.01f;
    }
}
