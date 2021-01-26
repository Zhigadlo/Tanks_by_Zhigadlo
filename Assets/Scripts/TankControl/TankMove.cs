namespace Scripts
{
    using UnityEngine;
    public class TankMove : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 0.1f;
        [SerializeField] private float _rotationSpeed = 0.1f;
        [SerializeField] private Transform _gameObject;

        private void Move()
        {
            float vert = Input.GetAxis("Vertical");
            Vector2 move = new Vector2(0, vert);
            _gameObject.Translate(move * _moveSpeed);
            //Vector2 moveDirection = Vector2.up;
            //_gameObject.AddRelativeForce(move * _moveSpeed);
        }

        private void Rotate()
        {
            float r = Input.GetAxis("Horizontal") * _rotationSpeed;
            Quaternion rotateAngle = Quaternion.Euler(0, 0, -r);

            Quaternion currentAngle = rotateAngle * _gameObject.transform.rotation;
            _gameObject.transform.rotation = currentAngle;
        }

        private void FixedUpdate()
        {
            Move();
            Rotate();
        }
    }
}