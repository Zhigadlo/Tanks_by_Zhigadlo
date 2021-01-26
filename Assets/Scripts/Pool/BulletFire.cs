namespace Pool
{
    using System.Collections.Generic;
    using UnityEngine;

    public class BulletFire : MonoBehaviour
    {
        [SerializeField] private int _pause = 50;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private int _bulletCount = 10;
        [SerializeField] private bool _willGrow = false;

        [SerializeField] private List<GameObject> _bullets = new List<GameObject>();

        private void Awake()
        {
            for (int i = 0; i < _bulletCount; ++i)
            {
                CreateBullet();
            }
        }

        GameObject CreateBullet()
        {
            GameObject obj = Instantiate(_bullet, transform.position, Quaternion.identity);
            obj.SetActive(false);
            _bullets.Add(obj);
            return obj;
        }

        GameObject GetPooledObject()
        {
            for(int i = 0; i < _bullets.Count; ++i)
            {
                if(!_bullets[i].activeSelf)
                {
                    return _bullets[i];
                }
            }

            if(_willGrow)
            {
                return CreateBullet();
            }

            return null;
        }

        public void Fire()
        {
            if(_pause <= 0)
            {
                GameObject newBullet = GetPooledObject();
                if(newBullet != null)
                {
                    newBullet.transform.position = transform.position;
                    newBullet.transform.rotation = transform.rotation;
                    newBullet.SetActive(true);
                    _pause = 20;
                }
            }
        }

        private void FixedUpdate()
        {
            if(_pause > 0)
            {
                _pause -= 1;
            }
        }
    }
}

