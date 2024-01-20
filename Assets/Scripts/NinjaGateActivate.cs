using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NinjaGateActivate : MonoBehaviour
{
    public GameObject meleeEnemy;
    public GameObject rangedEnemy;
    public GameObject superMeleeEnemy;

    public bool ninjaReady;
    // Start is called before the first frame update
    void Start()
    {
        ninjaReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Bullet.enemiesKilled >= 19)
        {
            ninjaReady = true;
        }
    }

    void OnColliderEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && ninjaReady == true)
        {
            SceneManager.LoadScene(5);
        }
    }
}