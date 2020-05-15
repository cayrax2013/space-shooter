using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _minDelayBetweenShots = 1.5f;
    [SerializeField] private float _maxDelayBetweenShots = 1.5f;

    private float _delayBetweenShots;
    //[SerializeField] private AudioSource _soundShot;

    private float _elapsedTime = 0;

    private void Start()
    {
        _delayBetweenShots = Random.Range(1.5f, 3f);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenShots)
        {
           // _soundShot.Play();
            Instantiate(_bullet, transform.position, Quaternion.Euler(0, 0, 90));
            _elapsedTime = 0;

            _delayBetweenShots = Random.Range(1.5f, 3f);
        }
    }
}
