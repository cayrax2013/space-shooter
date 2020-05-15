using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyNumberOne;
    [Header("The first wave")]
    [SerializeField] private float _delayBetweenSpawn = 2;
    [SerializeField] private int _amountEnemiesTheFirstrWave = 15;

    private void Start()
    {
        StartCoroutine(WaveNumberOne(_delayBetweenSpawn));
    }

    private IEnumerator WaveNumberOne(float delayBetweenSpawn)
    {
        var waitForSeconds = new WaitForSeconds(delayBetweenSpawn);

        for (int i = 0; i < _amountEnemiesTheFirstrWave; i++)
        {
            Instantiate(_enemyNumberOne, transform.position, Quaternion.Euler(0, 0, 180));

            yield return waitForSeconds;
        }
    }
}
