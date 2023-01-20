using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public MovementScripts movementScript;

    [Range(-1, 1)]
    public float zoom = 1.0f;
    public float zoomOffset = 0;

    [Range(0, 10)]
    public float verticalCameraDistance = 0;

    private Vector3 startPos;
    private float starDistance = 0;

    private void Start()
    {
        startPos = transform.position;
        starDistance = Vector3.Distance(movementScript.rigidbodies[0].transform.position, movementScript.rigidbodies[1].transform.position);
    }

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(movementScript.rigidbodies[0].transform.position, movementScript.rigidbodies[1].transform.position, 0.5f);
        transform.position = new Vector3(pos.x, pos.y, startPos.z);
        transform.Translate(new Vector3(0, 0, startPos.z - (Vector3.Distance(movementScript.rigidbodies[0].transform.position, movementScript.rigidbodies[1].transform.position) - starDistance) * zoom + zoomOffset), Space.Self);
    }
}
