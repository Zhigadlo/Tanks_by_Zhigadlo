namespace Scripts
{
    using UnityEngine;

    public class TowerRotate : MonoBehaviour
    {
        [SerializeField] private Transform _transformObject;
        [SerializeField] private float _towerRotateSpeed = 0.1f;

        private void Start()
        {
            _transformObject = this.transform;
        }
        private void Rotate()
        {
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _transformObject.position;
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(-angle, Vector3.forward);
            _transformObject.rotation = Quaternion.Slerp(_transformObject.rotation, rotation, _towerRotateSpeed);
        }

        private void FixedUpdate()
        {
            Rotate();
        }
    }
}