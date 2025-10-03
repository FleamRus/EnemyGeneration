using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 3.0f;
    private Vector3 _moveDirection = Vector3.forward;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _moveDirection, Space.Self);
    }

    public void SetMoveDirection(Vector3 direction)
    {
        _moveDirection = direction.normalized;
    }
}
