using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public bool pierce;
    public bool superPierce;

    public static int enemiesKilled;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (superPierce == false)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().enemyHP -= damage;
            if (pierce == false)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("StrongEnemy"))
        {
            collision.gameObject.GetComponent<StrongEnemyHealth>().strongEnemyHP -= damage/2;
            if(superPierce == false)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Dummy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().enemyHP -= damage;
            if (pierce == false)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<LaserTankHealth>().bossHP -= damage;
            if (superPierce == false)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Boss2"))
        {
            collision.gameObject.GetComponent<CyberNinjaHealth>().bossHP -= damage;
            if (superPierce == false)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Boss3"))
        {
            collision.gameObject.GetComponent<MothershipHealth>().bossHP -= damage;
            if (superPierce == false)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Secret"))
        {
            collision.gameObject.GetComponent<Secret>().found = true;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("EBullet"))
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        Debug.Log(enemiesKilled);
    }

}
