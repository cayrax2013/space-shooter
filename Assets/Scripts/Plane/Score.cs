using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private UnityEventInt _scoreChanged;
    [SerializeField] private UnityEvent _won;
    [SerializeField] private int _current = 0;

    private void Start()
    {
        _scoreChanged?.Invoke(_current);
    }

    public void TakeScore()
    {
        _current++;
        _scoreChanged?.Invoke(_current);

        if (_current >= 15)
            _won?.Invoke();
    }
}
