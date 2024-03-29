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

    public AudioSource nebulaSFX;

    public GameObject music;

    public GameObject shipCore;
    public ParticleSystem mothershipNebula;
    // Start is called before the first frame update
    void Start()
    {
        bossHP = 350.0f;
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
            music.SetActive(false);
            Instantiate(mothershipNebula, new Vector3(0f, 6.7f, -2.18f), Quaternion.identity);
            nebulaSFX.Play();
            gameObject.SetActive(false);
            Invoke(nameof(loadEnd), 5);
        }
    }

    void loadEnd()
    {
        SceneManager.LoadScene(0);
    }
}
