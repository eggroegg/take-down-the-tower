using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Lifespan());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().health -= 1.0f;
        }
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    IEnumerator Lifespan()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }
}
