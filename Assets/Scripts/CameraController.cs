using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public MovementScripts movementScript;
    public Transform target;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(movementScript.rigidbodies[0].transform.position, movementScript.rigidbodies[1].transform.position, 0.5f);
        target.position = new Vector3(pos.x, target.position.y, target.position.z);
    }
}
