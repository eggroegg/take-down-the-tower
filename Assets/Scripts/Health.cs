using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite fullHealth;
    public Sprite midHealth;
    public Sprite lowHealth;

    public GameObject[] lights;

    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 3:
                spriteRenderer.sprite = fullHealth;
                lights[0].SetActive(true);
                lights[1].SetActive(false);
                lights[2].SetActive(false);
                break;
            case 2:
                spriteRenderer.sprite = midHealth;
                lights[1].SetActive(true);
                lights[0].SetActive(false);
                lights[2].SetActive(false);
                break;
            case 1:
                spriteRenderer.sprite = lowHealth;
                lights[2].SetActive(true);
                lights[0].SetActive(false);
                lights[1].SetActive(false);
                break;
            case 0:
                PlayerDie();
                break;
            default:
                spriteRenderer.sprite = fullHealth;
                lights[0].SetActive(true);
                lights[1].SetActive(false);
                lights[2].SetActive(false);
                break;
        }
        //This must be done in Update or else the player won't take damage from enemy bullets
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

        if (collision.gameObject.CompareTag("Boss2"))
        {
            health -= 1.0f;
        }
    }

    void PlayerDie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameObject.SetActive(false);
    }
}
