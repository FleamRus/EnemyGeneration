using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _arrivedPoints;
    [SerializeField] private MoverPlayer _spawnObjectPlayer;
    [SerializeField] private MoverEnemies _spawnObjectEnemies;

    private int _pointSpawnPlyerIndex = 0;
    private float _spawnTime = 15f;

    private void Start()
    {
        SpawnObjectPlayers();

        StartCoroutine(SpawnCorutine());
    }

    private IEnumerator SpawnCorutine()
    {
        while (enabled)
        {
            SpawnObjectEnemies();

            yield return new WaitForSeconds(_spawnTime);
        }
    }

    private void SpawnObjectPlayers()
    {
        _spawnObjectPlayer = Instantiate(_spawnObjectPlayer);
        _spawnObjectPlayer.transform.position = _arrivedPoints[_pointSpawnPlyerIndex].position;

        _spawnObjectPlayer.SetWay(_arrivedPoints);
    }

    private void SpawnObjectEnemies()
    {
        MoverEnemies enemy =  Instantiate(_spawnObjectEnemies);

        enemy.transform.position = this.transform.position;
        enemy.SetTarget(_spawnObjectPlayer.transform);
    }
}
