using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Deathzone"))
        {
            transform.position = new Vector3(0, 1, -5);
        }
    }
}
