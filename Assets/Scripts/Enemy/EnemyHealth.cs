using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private UnityEvent _dead;
    [SerializeField] private int _current = 2;

    private GameObject _explosionEffect;
    private GameObject _plane;
    private Score _score;

    public void TakeDamage(int damage)
    {
        _current -= damage;
        if (_current <= 0)
            Die();
    }

    private void Start()
    {
        _explosionEffect = Resources.Load("ExplosionEnemyEffect") as GameObject;
        _plane = GameObject.Find("Plane") as GameObject;
        _score = _plane.GetComponent<Score>();
    }

    private void Die()
    {
        _score.TakeScore();
        var effect = Instantiate(_explosionEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1);
        Destroy(gameObject);
    }
}
