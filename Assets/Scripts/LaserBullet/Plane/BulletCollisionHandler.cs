using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    [SerializeField] private float _longevity = 2f;
    [SerializeField] private int _damage = 1;

    private void Start()
    {
        Destroy(gameObject, _longevity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out AsteroidHealth asteroidHealth))
        {
            asteroidHealth.TakeDamage(_damage);
            Die();
        }

        if (collision.TryGetComponent(out EnemyHealth enemyHealth))
        {
            enemyHealth.TakeDamage(_damage);
            Die();
        }

        if (collision.tag == "BulletDestroyer")
        {
            Destroy(gameObject);
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
