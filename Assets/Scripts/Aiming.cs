using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Vector3 parentPosition;
    Vector3 lookAtTargetPos;
    Rigidbody2D Rigidbody2D;

    void Update()
    {
        
        parentPosition = new Vector3 (transform.parent.position.x, transform.parent.position.y, transform.parent.position.z - 1);
        lookAtTargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - lookAtTargetPos, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        gameObject.transform.position = parentPosition;
        
    }

}
