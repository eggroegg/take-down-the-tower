using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float roSpeed;
    void Update()
    {
        transform.Rotate(0, 0, roSpeed * Time.deltaTime);
    }
}
