using UnityEngine;

public class TankTowerRotate : MonoBehaviour
{
    [SerializeField] private GameObject Tower;

    void FixedUpdate()
    {
        TowerRotate();
    }

    private void TowerRotate()
    {
	float _rotZ;
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        _rotZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
        Tower.transform.rotation = Quaternion.Euler(0, 0, -_rotZ);
    }
}
