using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTankAttack : MonoBehaviour
{
    public Animator animator;
    public float time = 0.0f;
    public float interpolationPeriod = 7.5f;

    public Transform barrel;
    public GameObject powerBullet;
    public GameObject weakBullet;

    public int numberOfTimesToRun;

    public float whatAttack;

    // Start is called before the first frame update
    void Start()
    {
        numberOfTimesToRun = 15;
    }

    // Update is called once per frame
    void Update()
    {
        whatAttack = Random.Range(1, 3);

        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {

            if(whatAttack == 1)
            {
                PowerShot();
            }

            if(whatAttack == 2)
            {
                animator.SetBool("Shooting (Rapid)", true);

                StartCoroutine(RapidShots());

                animator.SetBool("Shooting (Rapid)", false);
            }

            //StartCoroutine(RapidShots());

            time = 0.0f;

            //PowerShot();
        }
    }

    void PowerShot()
    {
        animator.SetBool("Shooting (Power)", true);

        Instantiate(powerBullet, barrel.position, Quaternion.identity);

        animator.SetBool("Shooting (Power)", false);
    }

    void RapidShot()
    {
        Instantiate(weakBullet, barrel.position, Quaternion.identity);
    }

    IEnumerator RapidShots()
    {
        for (int i = 0; i < numberOfTimesToRun; i++)
        {
            RapidShot();
            yield return new WaitForSeconds(0.2f);
        }
    }
}
