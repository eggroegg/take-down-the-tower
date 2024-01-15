using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class CyberNinjaAttack : MonoBehaviour
{
    public Animator animator;
    public float time = 0.0f;
    public float interpolationPeriod = 5.0f;

    public Transform hand;
    public GameObject shuriken;

    public int numberOfTimesToRun;

    public float whatAttack;

    public Transform player;

    public CyberNinjaMovement cyberNinjaMovement;

    public Transform playerPos;

    public bool phase2;

    public Light armLight;

    public AudioSource triShuriken;
    public AudioSource slash;

    public float moveSpeed = 7.5f;

    public ParticleSystem dashRes;

    // Start is called before the first frame update
    void Start()
    {
        phase2 = false;
        numberOfTimesToRun = 3;
        armLight.intensity = 0.0f;
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
                Slash();
            }

            if(whatAttack == 2)
            {
                animator.SetBool("Triple Shuriken", true);

                StartCoroutine(TShurikens());

                animator.SetBool("Triple Shuriken", false);
            }
           
            time = 0f;
        }
    }

    void Slash()
    {
        StartCoroutine(Slashf());
    }

    IEnumerator Slashf()
    {
        playerPos.transform.position = player.transform.position;

        animator.SetBool("Slash", true);
        armLight.intensity = 1.38f;

        cyberNinjaMovement.enabled = false;
        yield return new WaitForSeconds(0.5f);

        armLight.intensity = 0.0f;
        slash.Play();
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.1f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.2f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.3f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.4f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.5f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.6f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.7f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.8f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.9f);
        Instantiate(dashRes, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 1.0f);
        Instantiate(dashRes, transform.position, transform.rotation);

        if (phase2 == true)
        {
            playerPos.transform.position = player.transform.position;
            armLight.intensity = 1.38f;
            yield return new WaitForSeconds(0.15f);

            armLight.intensity = 0.0f;
            slash.Play();
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.1f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.2f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.3f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.4f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.5f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.6f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.7f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.8f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 0.9f);
            Instantiate(dashRes, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.Lerp(transform.position, playerPos.transform.position, 1.0f);
            Instantiate(dashRes, transform.position, transform.rotation);
        }

        cyberNinjaMovement.enabled = true;

        animator.SetBool("Slash", false);
    }

    void TShuriken()
    {
        Instantiate(shuriken, hand.position, Quaternion.identity);
        triShuriken.Play();
    }

    IEnumerator TShurikens()
    {
        for (int i = 0; i < numberOfTimesToRun; i++)
        {
            TShuriken();
            yield return new WaitForSeconds(0.15f);
        }
    }
}
