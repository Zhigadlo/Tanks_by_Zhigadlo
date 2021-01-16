namespace Pool
{
    using UnityEngine;

    public class ObjectFire : MonoBehaviour
    {
        [SerializeField] private float _speed = 2f;
        BulletFire bulletFire;
        private void Awake()
        {
            bulletFire = GetComponent<BulletFire>();
        }

        private void FixedUpdate()
        {
            if(Input.GetAxis("Fire1")!=0)
            {
                bulletFire.Fire();
            }
        }
    }
}
