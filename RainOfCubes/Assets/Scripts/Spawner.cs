using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] _spawnPoints;
    [SerializeField] GameObject _spawnCube;

    private float _spawnTime = 2f;

    private void Start()
    {
        StartCoroutine(SpawnCorutine());
    }

    private IEnumerator SpawnCorutine()
    {
        while (true)
        {
            SpawnCube();

            yield return new WaitForSeconds(_spawnTime);
        }
    }

    private void SpawnCube()
    {
        int minValue = 0;

        int indexSpawnPoin = Random.Range(minValue, _spawnPoints.Length);

        Transform spawnPoint = _spawnPoints[indexSpawnPoin];

        GameObject cube = _spawnCube = Instantiate(_spawnCube);
        cube.transform.position = spawnPoint.position;


        float minValueRange = -1f;
        float maxValueRange = 1f;
        Vector3 randomDirection = new(Random.Range(minValueRange, maxValueRange), 0, Random.Range(minValueRange, maxValueRange));

        cube.GetComponent<Mover>().SetMoveDirection(randomDirection);
    }
}
