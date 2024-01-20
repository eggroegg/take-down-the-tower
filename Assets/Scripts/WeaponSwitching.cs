using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSwitching : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public static bool weaponUnlocked;
    [Header("Energy Pistol")]
    public Sprite weapon1;
    public static bool pistolUnlocked;
    [Header("Energy Rifle")]
    public Sprite weapon2;
    public static bool rifleUnlocked;
    [Header("Laser Cannon")]
    public Sprite weapon3;
    public static bool cannonUnlocked;
    [Header("Energy Shotgun")]
    public Sprite weapon4;
    public static bool shotgunUnlocked;
    [Header("Laser Sword")]
    public Sprite weapon5;
    public Sprite weapon5Activated;
    public static bool swordUnlocked;
    [Header("Plasma Terminator")]
    public Sprite weapon6;
    public static bool terminatorUnlocked;

    void ChangeWeapon1()
    {
        spriteRenderer.sprite = weapon1;
    }

    void ChangeWeapon2()
    {
        spriteRenderer.sprite = weapon2;
    }

    void ChangeWeapon3()
    {
        spriteRenderer.sprite = weapon3;
    }

    void ChangeWeapon4()
    {
        spriteRenderer.sprite = weapon4;
    }

    void ChangeWeapon5()
    {
        spriteRenderer.sprite = weapon5;
    }

    void ChangeWeapon6()
    {
        spriteRenderer.sprite = weapon6;
    }

    void Update()
    {
        if (weaponUnlocked == false)
        {
            spriteRenderer.enabled = false;
        }
        else
        {
            spriteRenderer.enabled = true;
        }

        if (Input.GetKeyDown("1") && pistolUnlocked == true)
        {
            ChangeWeapon1();
        }

        if (Input.GetKeyDown("2") && rifleUnlocked == true)
        {
            ChangeWeapon2();
        }

        if (Input.GetKeyDown("3") && cannonUnlocked == true)
        {
            ChangeWeapon3();
        }

        if (Input.GetKeyDown("4") && shotgunUnlocked == true)
        {
            ChangeWeapon4();
        }

        if (Input.GetKeyDown("5") && swordUnlocked == true)
        {
            ChangeWeapon5();
        }

        if (Input.GetKeyDown("6") && terminatorUnlocked == true)
        {
            ChangeWeapon6();
        }
    }

    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            weaponUnlocked = false;
            pistolUnlocked = false;
            rifleUnlocked = false;
            cannonUnlocked = false;
            shotgunUnlocked = false;
            swordUnlocked = false;
            terminatorUnlocked = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            weaponUnlocked = true;
            pistolUnlocked = true;
            rifleUnlocked = false;
            cannonUnlocked = false;
            shotgunUnlocked = false;
            swordUnlocked = false;
            terminatorUnlocked = false;

        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            weaponUnlocked = true;
            pistolUnlocked = true;
            rifleUnlocked = false;
            shotgunUnlocked = false;
            swordUnlocked = false;
            terminatorUnlocked = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            weaponUnlocked = true;
            pistolUnlocked = true;
            rifleUnlocked = true;
            shotgunUnlocked = false;
            swordUnlocked = false;
            terminatorUnlocked = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            weaponUnlocked = true;
            pistolUnlocked = true;
            rifleUnlocked = true;
            shotgunUnlocked = false;
            terminatorUnlocked = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            weaponUnlocked = true;
            pistolUnlocked = true;
            rifleUnlocked = true;
            shotgunUnlocked = true;
            terminatorUnlocked = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            weaponUnlocked = true;
            pistolUnlocked = true;
            rifleUnlocked = true;
            shotgunUnlocked = true;
        }
    }
}
