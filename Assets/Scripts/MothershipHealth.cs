using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MothershipHealth : MonoBehaviour
{
    public float bossHP;

    public WeaponSwitching weaponSwitching;

    public MothershipAttack mothershipAttack;
    // Start is called before the first frame update
    void Start()
    {
        bossHP = 1.00f;
        //bossHP = 350.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (bossHP <= 175.0f)
        {
            mothershipAttack.interpolationPeriod = 3.0f;
            mothershipAttack.laserCooldown = 0.0f;
            mothershipAttack.secondPhase = true;
        }
        if (bossHP <= 88)
        {
            mothershipAttack.secondPhase = false;
            mothershipAttack.thirdPhase = true;
            mothershipAttack.interpolationPeriod = 2.0f;
            mothershipAttack.numberOfTimesToRun = 7;
        }
        if (bossHP <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(8);
        }
    }
}
