using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
	public GameObject[] weapons;
	public int selectedWeapon = 0;
	
	void Start()
	{
		SelectedWeapon();
	}

	void Update()
	{
		int previousWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if( selectedWeapon >= weapons.Length - 1)
            {
				selectedWeapon = 0;
            }
            else
            {
				selectedWeapon++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectedWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            selectedWeapon = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 4)
        {
            selectedWeapon = 3;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if (selectedWeapon <= 0)
			{
				selectedWeapon = weapons.Length-1;
			}
			else
			{
				selectedWeapon--;
			}
		}

		if (previousWeapon != selectedWeapon)
		{
			SelectedWeapon();
		}
	}

	void SelectedWeapon()
    {
		int i = 0;

        foreach (Transform weapon in transform)
        {
            if (weapon.gameObject.layer == LayerMask.NameToLayer("Weapon"))
            {
                if (i==selectedWeapon)
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