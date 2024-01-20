using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoom7 : MonoBehaviour
{
    public bool hasRun7;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(5).gameObject.SetActive(false);
        gameObject.transform.GetChild(6).gameObject.SetActive(false);
        hasRun7 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasRun7 == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            gameObject.transform.GetChild(4).gameObject.SetActive(true);
            gameObject.transform.GetChild(5).gameObject.SetActive(true);
            gameObject.transform.GetChild(6).gameObject.SetActive(true);
            hasRun7 = true;
        }
    }
}
