using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    [SerializeField] private float _delayBetweenSpawn = 2f;
    [SerializeField] private GameObject[] _asteroids;
    [Header("Позиция спавна астеройда")]
    [SerializeField] private float _minXPosition = -2.11f;
    [SerializeField] private float _maxXPosition = 2.21f;
    [SerializeField] private float _high = 5.38f;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenSpawn)
        {
            var randomPositionX = Random.Range(_minXPosition, _maxXPosition);
            var randomAsteroid = Random.Range(0, _asteroids.Length);

            Instantiate(_asteroids[randomAsteroid], new Vector2(randomPositionX, _high), Quaternion.identity);

            _elapsedTime = 0;
        }
    }
}
