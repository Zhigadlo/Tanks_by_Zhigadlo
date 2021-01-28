namespace Pool
{
    using UnityEngine;
    public class MortarBullet : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private Rigidbody2D _rb;
        private Vector3 _endPosition;

        private void Start()
        {
            _endPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        private void Diactivate()
        {
            gameObject.SetActive(false);
        }

        private void FixedUpdate()
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPosition, _speed);
        }

        private void OnCollisionEnter2D()
        {
            Diactivate();
        }
    }
}
