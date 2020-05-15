using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionHandler : MonoBehaviour
{
    [SerializeField] private int _damage = 20;

    private GameObject _plane;
    private PlaneHealth _planeHealth;

    private void Start()
    {
        _plane = GameObject.Find("Plane");
        _planeHealth = _plane.GetComponent<PlaneHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyDestroyer")
        {
            _planeHealth.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
