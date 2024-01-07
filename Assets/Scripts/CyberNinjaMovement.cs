using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyberNinjaMovement : MonoBehaviour
{

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    public float moveSpeed = 5f;

    int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                waypoints[waypointIndex].transform.position,
                                                moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }

        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }

        if (waypointIndex == 2)
        {
            gameObject.transform.localScale = new Vector3(-0.7f, 0.7f, 0.7f);
        }

        if(waypointIndex == 0)
        {
            gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }
    }
}
