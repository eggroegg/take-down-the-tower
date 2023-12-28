using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHP;

    public AudioSource enemyDie;

    public ParticleSystem enemyDieAnim;

    // Start is called before the first frame update
    void Start()
    {
        enemyHP = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHP <= 0.0f)
        {
            Bullet.enemiesKilled++;
            enemyDie.Play();
            enemyDieAnim.Play();
            gameObject.SetActive(false);
        }
    }
}
