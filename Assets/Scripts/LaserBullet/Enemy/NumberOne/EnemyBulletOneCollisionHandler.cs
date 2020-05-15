using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletOneCollisionHandler : MonoBehaviour
{
    [SerializeField] private int _damage = 20;

    private void Start()
    {
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlaneHealth planeHealth))
        {
            planeHealth.TakeDamage(_damage);
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
