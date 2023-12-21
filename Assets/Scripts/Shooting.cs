using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Shooting : MonoBehaviour
{
    public Transform muzzle;
    public GameObject bulletPrefab;
    public GameObject bulletsPrefab;

    public float bulletForce = 20.0f;
    public float fireRate = 1.0f;
    public float lifespan = 5.0f;
    public float bulletSize = 0.14162f;

    public float gunSize = 0.6584666f;

    public WeaponSwitching weaponSwitching;

    public Coroutine currentCoroutine;

    public AudioSource gunSFX;
    public AudioSource shotgunSFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && currentCoroutine == null && WeaponSwitching.weaponUnlocked == true && weaponSwitching.spriteRenderer.sprite != weaponSwitching.weapon4)
        {
            currentCoroutine = StartCoroutine(Fire());
            if(weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon5)
            {
                weaponSwitching.spriteRenderer.sprite = weaponSwitching.weapon5Activated;
            }
        }

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon5Activated)
        {
            currentCoroutine = StartCoroutine(Fire());
        }

        if (Input.GetButton("Fire1") && currentCoroutine == null && WeaponSwitching.weaponUnlocked == true && weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon4)
        {
            currentCoroutine = StartCoroutine(FireShotgun());
        }

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon1)
        {
            bulletForce = 20.0f;
            fireRate = 1.0f;
            lifespan = 3.0f;
            bulletSize = 0.14162f;
            bulletPrefab.GetComponent<Bullet>().damage = 1.0f;
            bulletPrefab.GetComponent<Bullet>().pierce = false;
            bulletPrefab.GetComponent<Bullet>().superPierce = false;
            gunSize = 0.6584666f;
            gunSFX.volume = 1.0f;
}

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon2)
        {
            bulletForce = 20.0f;
            fireRate = 0.1f;
            lifespan = 5.0f;
            bulletSize = 0.1f;
            bulletPrefab.GetComponent<Bullet>().damage = 0.5f;
            bulletPrefab.GetComponent<Bullet>().pierce = false;
            bulletPrefab.GetComponent<Bullet>().superPierce = false;
            gunSize = 0.6584666f;
            gunSFX.volume = 0.8f;
        }

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon3)
        {
            bulletForce = 10.0f;
            fireRate = 2.5f;
            lifespan = 10.0f;
            bulletSize = 0.4f;
            bulletPrefab.GetComponent<Bullet>().damage = 3.0f;
            bulletPrefab.GetComponent<Bullet>().pierce = true;
            bulletPrefab.GetComponent<Bullet>().superPierce = false;
            gunSize = 0.6584666f;
            gunSFX.volume = 1.5f;
        }

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon4)
        {
            bulletForce = 20.0f;
            fireRate = 2.0f;
            lifespan = 0.25f;
            bulletSize = 1.0f;
            bulletsPrefab.GetComponent<Bullet>().damage = 5.0f;
            bulletsPrefab.GetComponent<Bullet>().pierce = false;
            bulletsPrefab.GetComponent<Bullet>().superPierce = false;
            gunSize = 1.0f;
            shotgunSFX.volume = 1.0f;
        }

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon5)
        {
            bulletForce = -10.0f;
            fireRate = 0.01f;
            lifespan = 0.1f;
            bulletSize = 0.3f;
            bulletPrefab.GetComponent<Bullet>().damage = 0.1f;
            bulletPrefab.GetComponent<Bullet>().pierce = true;
            bulletPrefab.GetComponent<Bullet>().superPierce = true;
            gunSize = 1.3f;
            gunSFX.volume = 0.5f;
        }

        if (weaponSwitching.spriteRenderer.sprite == weaponSwitching.weapon6)
        {
            bulletForce = 30.0f;
            fireRate = 10.0f;
            lifespan = 25.0f;
            bulletSize = 1.0f;
            bulletPrefab.GetComponent<Bullet>().damage = 10f;
            bulletPrefab.GetComponent<Bullet>().pierce = true;
            bulletPrefab.GetComponent<Bullet>().superPierce = true;
            gunSize = 1.3f;
            gunSFX.volume = 2.0f;
        }
        gameObject.transform.localScale = new Vector3(gunSize, gunSize, gunSize);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();
        bullet.transform.localScale = new Vector3(bulletSize, bulletSize, bulletSize);
        body.AddForce(muzzle.up * bulletForce, ForceMode2D.Impulse);
        gunSFX.Play();
        Destroy(bullet, lifespan);
    }

    void ShootShotgun()
    {
        GameObject bullet = Instantiate(bulletsPrefab, muzzle.position, muzzle.rotation);
        Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();
        bullet.transform.localScale = new Vector3(bulletSize, bulletSize, bulletSize);
        body.AddForce(muzzle.up * bulletForce, ForceMode2D.Impulse);
        shotgunSFX.Play();
        Destroy(bullet, lifespan);
    }

    IEnumerator Fire()
    {
        Shoot();
        yield return new WaitForSeconds(fireRate);
        currentCoroutine = null;
    }

    IEnumerator FireShotgun()
    {
        ShootShotgun();
        yield return new WaitForSeconds(fireRate);
        currentCoroutine = null;
    }
}
