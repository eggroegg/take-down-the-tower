using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoom2 : MonoBehaviour
{
    public bool hasRun2;
    // Start is called before the first frame update
    void Start()
    {
        hasRun2 = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasRun2 == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            hasRun2 = true;
        }
    }
}
