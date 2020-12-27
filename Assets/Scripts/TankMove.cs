using UnityEngine;

public class TankMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.5f;
    [SerializeField] private float _rotationSpeed = 1.5f;
    private Transform _rb;
    void Start()
    {
        _rb = GetComponent<Transform>(); 
    }
    void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        float vert = Input.GetAxis("Vertical");
        Vector3 move = new Vector2(0 , vert);
        _rb.Translate(move * _moveSpeed);
    }

    private void Rotate()
    {
        float R = Input.GetAxis("Horizontal") * _rotationSpeed;
        Quaternion RotateAngle = Quaternion.Euler(0, 0, -R);

        Quaternion CurrentAngle = RotateAngle * _rb.transform.rotation;
        _rb.transform.rotation = CurrentAngle;
    }
}
