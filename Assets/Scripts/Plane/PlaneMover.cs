using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _high = -4.38f;
    [SerializeField] private float _minXPosition = -2.11f;
    [SerializeField] private float _maxXPosition = 2.21f;

    private void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, _minXPosition, _maxXPosition), _high);
    }

    public void Move(float direction)
    {
        transform.Translate(Vector3.down * direction * _speed * Time.deltaTime);
    }
}
