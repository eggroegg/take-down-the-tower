using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoom5 : MonoBehaviour
{
    public bool hasRun5;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        hasRun5 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasRun5 == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            gameObject.transform.GetChild(4).gameObject.SetActive(true);
            hasRun5 = true;
        }
    }
}
