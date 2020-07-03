using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_ShootController : MonoBehaviour
{
    public List<FPS_Weapon> weapons;
    public FPS_Weapon currentWeapon;
    private int currentWeaponIndex = -1;
    private int previousWeaponIndex = -1;


    // Start is called before the first frame update
    void Start()
    {
        currentWeapon = weapons[0];
        ChangeWeapon(0);
    }

    // Update is called once per frame
    void Update()
    {
        bool mouseLeftClick = Input.GetMouseButtonDown(0);
        bool mouseLeftHold = Input.GetMouseButton(0);


        if (mouseLeftClick || mouseLeftHold)
        {
            currentWeapon.Fire();
        }

        if (Input.GetKeyDown(KeyCode.Q)) {
            ChangeWeapon(previousWeaponIndex);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            currentWeapon.Reload();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            ChangeWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeWeapon(2);
        }

    }

    private void FixedUpdate()
    {

    }


    private void ChangeWeapon(int index) {
        if (index != currentWeaponIndex) {
            previousWeaponIndex = currentWeaponIndex;

            currentWeapon.gameObject.SetActive(false);
            currentWeapon = weapons[index];
            currentWeapon.gameObject.SetActive(true);

            currentWeapon.ShowWeapon();

            currentWeaponIndex = index;
        }

    }

    public FPS_Weapon GetCurrentWeapon() { return currentWeapon; }

}
