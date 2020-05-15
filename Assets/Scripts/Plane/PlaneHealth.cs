using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]
public class UnityEventInt : UnityEvent<int> { }

public class PlaneHealth : MonoBehaviour
{
    [SerializeField] private UnityEventInt _healthChanged;
    [SerializeField] private UnityEvent _died;
    [SerializeField] private int _current = 100;
    [SerializeField] private GameObject _planeExplosion;

    public void TakeDamage(int damage)
    {
        _current -= damage;

        _healthChanged?.Invoke(_current);

        if (_current <= 0)
        {
            Die();
        }
    }

    private void Start()
    {
        _healthChanged?.Invoke(_current);
    }

    private void Die()
    {
        _died?.Invoke();
        Instantiate(_planeExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
