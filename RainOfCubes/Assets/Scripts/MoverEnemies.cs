using UnityEngine;

public class MoverEnemies : MonoBehaviour
{
    private float _speed = 1.0f;
    private Transform _target;

    private void Update()
    {
        MoveToTarget();
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void MoveToTarget()
    {
        Transform target = _target;

        transform.position = Vector3.Lerp(transform.position, target.position, _speed * Time.deltaTime);
    }
}
