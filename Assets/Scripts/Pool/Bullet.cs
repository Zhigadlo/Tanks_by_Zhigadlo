namespace Pool
{
    using UnityEngine;

    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;

        private void Diactivate()
        {
            gameObject.SetActive(false);
        }

        private void FixedUpdate()
        {
            transform.Translate(0f, _speed, 0f);
            
        }

        private void OnCollisionEnter2D()
        {
            Diactivate();
        }
    }
}
