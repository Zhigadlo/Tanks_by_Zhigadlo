using UnityEngine;

public class TankTowerRotate : MonoBehaviour
{
    public GameObject Tower;
    private float _rotZ;

    void FixedUpdate()
    {
        TowerRotate();
    }

    private void TowerRotate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        _rotZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
        Tower.transform.rotation = Quaternion.Euler(0, 0, -_rotZ);
    }
}
