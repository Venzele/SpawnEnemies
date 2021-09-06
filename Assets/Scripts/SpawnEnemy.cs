using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private float _timeout;

    private void Start()
    {
        StartCoroutine(SetEnemies());
    }

    private IEnumerator SetEnemies()
    {
        var waitForSeconds = new WaitForSeconds(_timeout);

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            Instantiate(_template, _spawnPoints.GetChild(i).position, Quaternion.identity);

            yield return waitForSeconds;
        }
    }
}
