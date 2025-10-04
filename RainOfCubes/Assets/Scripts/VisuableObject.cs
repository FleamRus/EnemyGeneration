using UnityEngine;

public class VisibleObject : MonoBehaviour
{
    [SerializeField] private Color _colorGizmo = new(1f,0f,0f,0.1f);
    [SerializeField] private float _size = 1f;

    private void OnDrawGizmos()
    {
        Gizmos.color = _colorGizmo;
        Gizmos.DrawSphere(transform.position, _size);
    }
}