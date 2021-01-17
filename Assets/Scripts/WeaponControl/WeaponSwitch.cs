namespace SwitchControll
{
    using UnityEngine;

    public class WeaponSwitch : MonoBehaviour
    {
        [SerializeField] private int _weaponSwitch = 0;

        private void Start()
        {
            SelectWeapon();
        }

        private void FixedUpdate()
        {
            int currentWeapon = _weaponSwitch;

            if(Input.GetAxis("Mouse ScrollWheel")>0f)
            {
                if(_weaponSwitch >= transform.childCount - 1)
                {
                    _weaponSwitch = 0;
                }
                _weaponSwitch++;
            }

            if (Input.GetAxis("Mouse ScorllWheel") < 0f)
            {
                if (_weaponSwitch <= 0)
                {
                    _weaponSwitch = transform.childCount - 1;
                }
                _weaponSwitch--;
            }

            if(currentWeapon!=_weaponSwitch)
            {
                SelectWeapon();
            }
        }
        void SelectWeapon()
        {
            int i = 0;
            foreach(Transform weapon in transform)
            {
                if(i == _weaponSwitch)
                {
                    weapon.gameObject.SetActive(true);
                }
                else
                {
                    weapon.gameObject.SetActive(false);
                }
                i++;
            }
        }
    }
}
