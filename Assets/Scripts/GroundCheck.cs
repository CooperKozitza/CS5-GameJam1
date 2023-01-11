using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool OnGround { get; private set; }

    public float hitDistance = 0.5f;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down) * hitDistance, out hit, hitDistance))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hitDistance, Color.red);
            OnGround = true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 100, Color.white);
            OnGround = false;
        }
        Debug.Log(OnGround ? "yea" : "nah");
    }
}
