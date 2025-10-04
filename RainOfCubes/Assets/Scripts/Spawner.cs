using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] _arrivedPoints;
    [SerializeField] Mover _spawnObject;

    private float _spawnTime = 2f;

    private void Start()
    {
        StartCoroutine(SpawnCorutine());
    }

    private IEnumerator SpawnCorutine()
    {
        while (enabled)
        {
            SpawnCube();

            yield return new WaitForSeconds(_spawnTime);
        }
    }

    private void SpawnCube()
    {
        Spawner spawner = GetComponent<Spawner>();

        _spawnObject = Instantiate(_spawnObject);
        _spawnObject.transform.position = spawner.transform.position;

        _spawnObject.SetWay(_arrivedPoints);
    }
}
