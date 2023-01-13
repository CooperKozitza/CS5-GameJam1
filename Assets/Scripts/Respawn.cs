using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector3 respawnPos;

    // Start is called before the first frame update
    void Start()
    {
        respawnPos = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Deathzone"))
        {
            Debug.Log(respawnPos.x.ToString() + " " + respawnPos.y.ToString());
            transform.position = respawnPos + new Vector3(0, 10, 0);
        }
        else if (other.CompareTag("Checkpoint"))
        {
            respawnPos = other.transform.position;
        }
    }
}
