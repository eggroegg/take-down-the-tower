using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankDoorOpen : MonoBehaviour
{
    public GameObject meleeEnemy;
    public GameObject rangedEnemy;

    public bool tankReady;
    // Start is called before the first frame update
    void Start()
    {
        tankReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Bullet.enemiesKilled >= 14)
        {
            tankReady = true;
        }
        Debug.Log(Bullet.enemiesKilled);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && tankReady == true)
        {
            SceneManager.LoadScene(3);
        }
    }
}