namespace Scripts
{
    using UnityEngine;
    public class TankMove : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 0.1f;
        [SerializeField] private float _rotationSpeed = 0.1f;
        [SerializeField] private Transform _gmTransform;

        private void Move()
        {
            float vert = Input.GetAxis("Vertical");
            Vector3 move = new Vector2(0, vert);
            _gmTransform.Translate(move * _moveSpeed);
        }

        private void Rotate()
        {
            float r = Input.GetAxis("Horizontal") * _rotationSpeed;
            Quaternion rotateAngle = Quaternion.Euler(0, 0, -r);

            Quaternion currentAngle = rotateAngle * _gmTransform.transform.rotation;
            _gmTransform.transform.rotation = currentAngle;
        }

        private void FixedUpdate()
        {
            Move();
            Rotate();
        }
    }
}