using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _points;

    private WaitForSeconds _delay = new WaitForSeconds(2f);
    private Coroutine _createEnemiesJob;

    private void Start()
    {
        _createEnemiesJob = StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        foreach (var point in _points)
        {
            Enemy newEnemy  = Instantiate(_enemy, point.position, Quaternion.identity);

            yield return _delay;
        }
    }
}