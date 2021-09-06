using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _wolf;
    [SerializeField] private Transform _pointsSpawn;
    [SerializeField] private float _timeout;

    private void Start()
    {
        StartCoroutine(SetEnemy());
    }

    private IEnumerator SetEnemy()
    {
        var waitForOneSeconds = new WaitForSeconds(_timeout);

        for (int i = 0; i < _pointsSpawn.childCount; i++)
        {
            Instantiate(_wolf, _pointsSpawn.GetChild(i).position, Quaternion.identity);

            yield return waitForOneSeconds;
        }
    }
}
