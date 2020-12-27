using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private string _playerTag;
    [SerializeField] private float _movingSpeed;

    private void Awake()
    {
        if (this._playerTransform == null)
        {
            if(this._playerTag == "")
            {
                this._playerTag = "Player";
            }

            this._playerTransform = GameObject.FindGameObjectWithTag(this._playerTag).transform;
        }

        this._playerTransform = GameObject.FindGameObjectWithTag(this._playerTag).transform;

        this.transform.position = new Vector3()
        {
            x = this._playerTransform.position.x,
            y = this._playerTransform.position.y,
            z = this._playerTransform.position.z - 10,
        };

    }

    private void Update()
    {
        if(this._playerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = this._playerTransform.position.x,
                y = this._playerTransform.position.y,
                z = this._playerTransform.position.z - 10,
            };

            Vector3 pos = Vector3.Lerp(a: this.transform.position, b: target, t: this._movingSpeed * Time.deltaTime);

            this.transform.position = pos;
        }
    }
}
