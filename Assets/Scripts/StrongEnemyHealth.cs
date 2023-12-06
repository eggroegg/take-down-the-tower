using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StrongEnemyHealth : MonoBehaviour
{
    public float strongEnemyHP;

    // Start is called before the first frame update
    void Start()
    {
        strongEnemyHP = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (strongEnemyHP <= 0.0f)
        {
            Bullet.enemiesKilled++;
            gameObject.SetActive(false);
        }
    }
}