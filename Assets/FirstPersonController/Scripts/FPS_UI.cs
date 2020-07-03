using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_UI : MonoBehaviour
{
    public static FPS_UI s;

    public Text ammoText;
    private FPS_ShootController _playerFPS;

    private void Awake()
    {
        s = this;
        _playerFPS = FindObjectOfType<FPS_ShootController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FPS_FireWeapon fw = _playerFPS.GetCurrentWeapon().GetComponent<FPS_FireWeapon>();
        if (fw != null) {
            UpdateAmmoText(fw.GetCurrentBullets(), fw.GetCartridgeSize());
        }
        else UpdateAmmoText(0, 0);
    }

    public void UpdateAmmoText(int currentBullets, int cartridgeSize) {
        string s = (cartridgeSize > 0) ? (currentBullets + " / " + cartridgeSize) : "";
        ammoText.text = s;
    }
}
