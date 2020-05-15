using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPlane : MonoBehaviour
{
    private GameObject _explosionEffect;

    private void Start()
    {
        _explosionEffect = Resources.Load("ExplosionPlaneEffect") as GameObject;

        StartCoroutine(Explosion());
    }

    private IEnumerator Explosion()
    {
        var waitForSeconds = new WaitForSeconds(0.7f);

        for (int i = 0; i < 7; i++)
        {
            var effect = Instantiate(_explosionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1);

            yield return waitForSeconds;
        }
    }
}
