using UnityEngine;

namespace TankControll
{
    public class TankTowerRotate : MonoBehaviour
    {
        [SerializeField] private Transform _transformObject;
        [SerializeField] private float _towerRotateSpeed = 0.1f;
        private Vector2 _currentDirection = new Vector3(0f, 1f, 0f);

        private void Start()
        {
            _transformObject = this.transform;
        }
        private void TowerRotate()
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 objectPos = _transformObject.position;

            Vector2 direction = mousePos - objectPos;
            direction.Normalize();

            _currentDirection = Vector2.Lerp(_currentDirection, direction, _towerRotateSpeed);
            _transformObject.up = _currentDirection;
        }

        private void FixedUpdate()
        {
            TowerRotate();
        }
    }
}