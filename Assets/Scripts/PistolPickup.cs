using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickup : MonoBehaviour
{
    public WeaponSwitching weaponSwitching;

    public GameObject teleporter;
    public void PickupPistol()
    {
        WeaponSwitching.weaponUnlocked = true;
        WeaponSwitching.pistolUnlocked = true;
        gameObject.SetActive(false);
    }

    public void PickupRifle()
    {
        WeaponSwitching.rifleUnlocked = true;
        teleporter.SetActive(true);
        gameObject.SetActive(false);
    }

    public void PickupRail()
    {
        WeaponSwitching.cannonUnlocked = true;
        gameObject.SetActive(false);
    }

    public void PickupShotgun()
    {
        WeaponSwitching.shotgunUnlocked = true;
        teleporter.SetActive(true);
        gameObject.SetActive(false);
    }
    
    public void PickupSword()
    {
        WeaponSwitching.swordUnlocked = true;
        gameObject.SetActive(false);
    }

    public void PickupTerminator()
    {
        WeaponSwitching.terminatorUnlocked = true;
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
