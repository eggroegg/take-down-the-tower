using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret : MonoBehaviour
{
    public bool found;
    public GameObject secretRoom;
    public GameObject secretWalls;
    // Start is called before the first frame update
    void Start()
    {
        secretWalls.SetActive(true);
        secretRoom.SetActive(false);
        found = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (found == true)
        {
            secretWalls.SetActive(false);
            secretRoom.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
