using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAttack : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _delayBetweenShots = 2f;
    [SerializeField] private AudioSource _soundShot;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenShots)
        {
            _soundShot.Play();
            Instantiate(_bullet, transform.position, Quaternion.Euler(0, 0, 90));
            _elapsedTime = 0;
        }
    }
}
