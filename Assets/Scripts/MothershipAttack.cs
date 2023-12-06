using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MothershipAttack : MonoBehaviour
{
    public Animator animator;
    public float time = 0.0f;
    public float interpolationPeriod = 6.0f;

    public Transform laserBarrel;
    public Transform missileBarrel1;
    public Transform missileBarrel2;
    public GameObject megaLaser;
    public GameObject saw;
    public GameObject missile;

    public int numberOfTimesToRun;
    public float laserCooldown;

    public float whatAttack;
    public float whatBarrel;

    public Transform player;

    public Transform playerPos;

    public bool secondPhase;
    public bool thirdPhase;
    // Start is called before the first frame update
    void Start()
    {
        numberOfTimesToRun = 5;
        laserCooldown = 2.5f;
        secondPhase = false;
        thirdPhase = false;
    }

    // Update is called once per frame
    void Update()
    {
        whatAttack = Random.Range(1, 4);
        whatBarrel = Random.Range(1, 3);

        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            if(whatAttack == 1)
            {
                animator.SetBool("QMissile", true);

                StartCoroutine(QuintupleMissile());

                animator.SetBool("QMissile", false);
            }

            if(whatAttack == 2)
            {
                MLaser();
            }

            if(whatAttack == 3)
            {
                DSaw();
            }

            time = 0.0f;
        }
    }

    void MLaser()
    {
        StartCoroutine(MegaLaser());
    }

    IEnumerator MegaLaser()
    {
        animator.SetBool("MLaser", true);

        yield return new WaitForSeconds(0.75f);

        Instantiate(megaLaser, laserBarrel.position, Quaternion.identity);

        yield return new WaitForSeconds(laserCooldown);

        animator.SetBool("MLaser", false);
    }

    void DSaw()
    {
        animator.SetBool("DSaw", true);

        Instantiate(saw, missileBarrel1.position, Quaternion.identity);
        Instantiate(saw, missileBarrel2.position, Quaternion.identity);

        animator.SetBool("DSaw", false);
    }

    void QMissile()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (whatBarrel == 1)
        {
            Instantiate(missile, missileBarrel1.position, Quaternion.identity);
        }
        if(whatBarrel == 2)
        {
            Instantiate(missile, missileBarrel2.position, Quaternion.identity);
        }
    }

    IEnumerator QuintupleMissile()
    {
        for (int i = 0; i < numberOfTimesToRun; i++)
        {
            QMissile();
            yield return new WaitForSeconds(0.85f);
        }
    }
}
