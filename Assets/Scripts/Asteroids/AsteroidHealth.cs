using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    [SerializeField] private int _currentHealth = 1;
    [SerializeField] private float _longevity = 0f;

    private GameObject _explosionEffect;

    private void Start()
    {
        _explosionEffect = Resources.Load("ExplosionEffect") as GameObject;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        var effect =  Instantiate(_explosionEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1);
        Destroy(gameObject, _longevity);
    }
}
