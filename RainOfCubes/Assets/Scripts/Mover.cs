using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 3.0f;
    private Transform[] _targets;
    private int _currentTargetIndex = 0;

    private void Update()
    {
        MoveWay();
    }

    public void SetWay(Transform[] targets)
    {
        _targets = targets;
    }

    private void MoveWay()
    {
        float minDistanceToTarget = 0.05f;
        Transform target = _targets[_currentTargetIndex];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < minDistanceToTarget)
        {
            _currentTargetIndex++;

            if (_currentTargetIndex >= _targets.Length)
            {
                enabled = false;
            }
        }
    }
}
