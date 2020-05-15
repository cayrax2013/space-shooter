using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigzagMovementEnemy : MonoBehaviour
{
    [SerializeField] private float _directionX = 1f;
    [SerializeField] private float _delayBetweenSteps = 1f;
    [SerializeField] private float _directionY = 1f;
    [SerializeField] private float _speed = 1f;

    private float _elapsedMovementTime = 0;
    private bool _isRight = true;
    private Vector2 _direction;

    private void Start()
    {
        _direction = new Vector2(_directionY, _directionX);
    }

    private void Update()
    {
        MoveZigzag();
    }

    private void MoveZigzag()
    {
        _elapsedMovementTime += Time.deltaTime;

        transform.Translate(_direction * Time.deltaTime * _speed);

        if (_elapsedMovementTime >= _delayBetweenSteps)
        {   
            _isRight = !_isRight;
            _elapsedMovementTime = 0;
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        _direction.x *= -1;
    }
}
