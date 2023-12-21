using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform enemyBulletPos;

    public float timer;

    public float enemyFireRate;

    public AudioSource enemyShoot;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            enemyFireRate = 2.0f;
        }

        if (gameObject.CompareTag("StrongEnemy"))
        {
            enemyFireRate = 1.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > enemyFireRate)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(enemyBullet, enemyBulletPos.position, Quaternion.identity);
        enemyShoot.Play();
    }
}
