using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite fullHealth;
    public Sprite midHealth;
    public Sprite lowHealth;

    public GameObject fullLight;
    public GameObject midLight;
    public GameObject lowLight;

    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 3.0f)
        {
            spriteRenderer.sprite = fullHealth;
            fullLight.SetActive(true);
            midLight.SetActive(false);
            lowLight.SetActive(false);
            
        }
        if (health == 2.0f)
        {
            spriteRenderer.sprite = midHealth;
            fullLight.SetActive(false);
            midLight.SetActive(true);
            lowLight.SetActive(false);
        }
        if (health == 1.0f)
        {
            spriteRenderer.sprite = lowHealth;
            fullLight.SetActive(false);
            midLight.SetActive(false);
            lowLight.SetActive(true);
        }
        if (health <= 0.0f)
        {
            Debug.Log("You Died.");
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 1.0f;
        }

        if (collision.gameObject.CompareTag("StrongEnemy"))
        {
            health -= 1.0f;
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            health -= 1.0f;
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            health -= 2.0f;
        }
    }
}
