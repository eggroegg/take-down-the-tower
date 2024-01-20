using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTeleporterActivate : MonoBehaviour
{
    public GameObject meleeEnemy;
    public GameObject rangedEnemy;
    public GameObject superMeleeEnemy;
    public GameObject superRangedEnemy;

    public bool worthy;
    // Start is called before the first frame update
    void Start()
    {
        worthy = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Bullet.enemiesKilled >= 29)
        {
            worthy = true;
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            gameObject.transform.GetChild(0).gameObject.GetComponent<Light>().enabled = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && worthy == true)
        {
            SceneManager.LoadScene(7);
        }
    }
}
