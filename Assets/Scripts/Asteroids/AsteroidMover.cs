using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _angle = 15f;

    private void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed, Space.World);
        transform.Rotate(0, 0, _angle * Time.deltaTime);
    }
}
