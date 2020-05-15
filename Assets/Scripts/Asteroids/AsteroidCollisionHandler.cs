using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollisionHandler : MonoBehaviour
{
    [SerializeField] private float _longevity = 7f;
    [SerializeField] private int _damage = 20;

    private void Start()
    {
        Destroy(gameObject, _longevity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlaneHealth planeHealth))
        {
            planeHealth.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
