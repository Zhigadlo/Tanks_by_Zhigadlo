namespace Pool
{
    using UnityEngine;
    using Scripts;

    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        TowerRotate gunPosition;

        private void Start()
        {
            gunPosition = GetComponent<TowerRotate>();
        }
        private void OnEnable()
        {
            Invoke("Diactivate", 3f);
        }

        void Diactivate()
        {
            gameObject.SetActive(false);
        }

        private void FixedUpdate()
        {
            transform.Translate(0f, _speed, 0f);
        }
    }
}
