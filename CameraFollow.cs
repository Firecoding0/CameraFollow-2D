using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothTime = 0.3f;
    [SerializeField] private Vector3 _offset;

    private Vector3 _currentVelocity = Vector3.zero;

    private void LateUpdate() {
        if (_target == null) {
            return;
        }

        Vector3 targetPosition = _target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, _smoothTime);
    }
}