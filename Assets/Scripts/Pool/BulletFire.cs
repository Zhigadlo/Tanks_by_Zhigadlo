namespace Pool
{
    using System.Collections.Generic;
    using UnityEngine;

    public class BulletFire : MonoBehaviour
    {
        [SerializeField] private int pause = 50;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private int bulletCount = 10;
        [SerializeField] private bool willGrow = false;

        [SerializeField] private List<GameObject> bullets = new List<GameObject>();

        private void Awake()
        {
            for (int i = 0; i < bulletCount; ++i)
            {
                CreateBullet();
            }
        }

        GameObject CreateBullet()
        {
            GameObject obj = (GameObject)Instantiate(_bullet, transform.position, Quaternion.identity);
            obj.SetActive(false);
            bullets.Add(obj);
            return obj;
        }

        GameObject GetPooledObject()
        {
            for(int i = 0; i < bullets.Count; ++i)
            {
                if(!bullets[i].activeSelf)
                {
                    return bullets[i];
                }
            }

            if(willGrow)
            {
                return CreateBullet();
            }

            return null;
        }

        public void Fire()
        {
            if(pause <= 0)
            {
                GameObject newBullet = GetPooledObject();
                if(newBullet != null)
                {
                    newBullet.transform.position = transform.position;
                    newBullet.SetActive(true);
                    pause = 20;
                }
            }
        }

        private void Update()
        {
            if(pause > 0)
            {
                pause -= 1;
            }
        }
    }
}

