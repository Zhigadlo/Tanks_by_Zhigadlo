namespace Scripts
{
    using UnityEngine;
    using UnityEngine.UI;

    public class HPControll : MonoBehaviour
    {
        [SerializeField] Image _bar;
        [SerializeField] private float _fill = 0.1f;

        private void Start()
        {
            _fill = 1.0f;
        }

        private void FixedUpdate()
        {
            _bar.fillAmount = _fill;
            if (_bar.fillAmount <= 0)
                Object.Destroy(gameObject);
        }

        private void OnCollisionEnter2D()
        {
            _fill -= 0.1f;
        }
    }
}
