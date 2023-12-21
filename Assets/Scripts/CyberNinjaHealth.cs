using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyberNinjaHealth : MonoBehaviour
{
    public float bossHP;

    public CyberNinjaAttack cyberNinjaAttack;

    public GameObject shotgunPickup;

    public AudioSource ninjaDie;

    // Start is called before the first frame update
    void Start()
    {
        shotgunPickup.SetActive(false);
        bossHP = 200.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (bossHP <= 100.0f)
        {
            cyberNinjaAttack.interpolationPeriod = 2.5f;
            cyberNinjaAttack.numberOfTimesToRun = 6;
            cyberNinjaAttack.phase2 = true;
        }

        if (bossHP <= 0.0f)
        {
            ninjaDie.Play();
            shotgunPickup.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
