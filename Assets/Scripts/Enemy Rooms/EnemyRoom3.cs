using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoom3 : MonoBehaviour
{
    public bool hasRun3;
    // Start is called before the first frame update
    void Start()
    {
        hasRun3 = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasRun3 == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            hasRun3 = true;
        }
    }
}
