using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleSaw : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        force = 12f;

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        StartCoroutine(Lifespan());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().health -= 1.0f;
        }
    }

    IEnumerator Lifespan()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
