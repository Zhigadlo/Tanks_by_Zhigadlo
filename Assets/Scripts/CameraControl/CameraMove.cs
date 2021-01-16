namespace Scripts
{
    using UnityEngine;
    public class CameraMove : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private float _movingSpeed;

        private void FixedUpdate()
        {
            if (this._playerTransform)
            {
                Vector3 target = new Vector3()
                {
                    x = this._playerTransform.position.x,
                    y = this._playerTransform.position.y,
                    z = this._playerTransform.position.z - 10,
                };

                Vector3 pos = Vector3.Lerp(this.transform.position, target, this._movingSpeed);

                this.transform.position = pos;
            }
        }
    }
}
