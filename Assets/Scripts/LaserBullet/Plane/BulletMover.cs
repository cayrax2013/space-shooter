using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Vector2 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }
}
