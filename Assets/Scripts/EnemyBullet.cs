using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().health -= 1.0f;
        }
        Destroy(gameObject);
    }
}
