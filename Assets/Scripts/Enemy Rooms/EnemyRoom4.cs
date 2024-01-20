using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoom4 : MonoBehaviour
{
    public bool hasRun4;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        hasRun4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasRun4 == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            hasRun4 = true;
        }
    }
}
