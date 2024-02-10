using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickup : MonoBehaviour
{
    public WeaponSwitching weaponSwitching;

    public GameObject teleporter;

    public AudioSource pickup;
    public void PickupPistol()
    {
        WeaponSwitching.weaponUnlocked = true;
        WeaponSwitching.pistolUnlocked = true;
        pickup.Play();
        gameObject.SetActive(false);
    }

    public void PickupRifle()
    {
        WeaponSwitching.rifleUnlocked = true;
        teleporter.SetActive(true);
        pickup.Play();
        gameObject.SetActive(false);
    }

    public void PickupRail()
    {
        WeaponSwitching.cannonUnlocked = true;
        pickup.Play();
        gameObject.SetActive(false);
    }

    public void PickupShotgun()
    {
        WeaponSwitching.shotgunUnlocked = true;
        teleporter.SetActive(true);
        pickup.Play();
        gameObject.SetActive(false);
    }
    
    public void PickupSword()
    {
        WeaponSwitching.swordUnlocked = true;
        pickup.Play();
        gameObject.SetActive(false);
    }

    public void PickupTerminator()
    {
        WeaponSwitching.terminatorUnlocked = true;
        pickup.Play();
        gameObject.SetActive(false);
    }
}
