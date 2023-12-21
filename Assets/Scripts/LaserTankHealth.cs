using System.Collections;
using System.Collections.Generic;
/*using UnityEditor.Tilemaps;*/
using UnityEngine;

public class LaserTankHealth : MonoBehaviour
{
    public float bossHP;

    public GameObject riflePickup;

    public AudioSource tankDie;

    // Start is called before the first frame update
    void Start()
    {
        riflePickup.SetActive(false);
        bossHP = 75.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (bossHP <= 0.0f)
        {
            tankDie.Play();
            riflePickup.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
