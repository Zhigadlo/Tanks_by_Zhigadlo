namespace Pool
{
    using UnityEngine;

    public class ObjectFire : MonoBehaviour
    {
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
