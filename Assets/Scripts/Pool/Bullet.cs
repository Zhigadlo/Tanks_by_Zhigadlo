namespace Pool
{
    using UnityEngine;

    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private Rigidbody2D _rb;

        private void Diactivate()
        {
            gameObject.SetActive(false);
        }

        private void FixedUpdate()
        {
            //transform.Translate(0f, _speed, 0f);
            Vector2 direction = Vector2.up;
            _rb.AddRelativeForce(direction * _speed);
        }

        private void OnCollisionEnter2D()
        {
            Diactivate();
        }
    }
}
