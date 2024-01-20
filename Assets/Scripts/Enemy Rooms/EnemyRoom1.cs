using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoom1 : MonoBehaviour
{
    public bool hasRun1;
    // Start is called before the first frame update
    void Start()
    {
        hasRun1 = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasRun1 == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            hasRun1 = true;
        }
    }
}
