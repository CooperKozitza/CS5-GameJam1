using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour
{
    public List<Rigidbody> rigidbodies;

    [Range(0, 10)]
    public float speed = 1;

    [Range(0, 10)]
    public float jumpHeight = 5;

    private bool jump = false;

    // Update is called once per frame
    void Update()
    {
        jump = Input.GetAxisRaw("Jump") > 0 && rigidbodies.FindAll(x => !x.GetComponent<GroundCheck>().OnGround && Mathf.Abs(x.velocity.y) >= 0.01).Count < 2 ? true : false;
        
        foreach (Rigidbody rb in rigidbodies)
        {
            Vector3 velocity = new Vector3(Input.GetAxisRaw("Horizontal") > 0 ? speed : Input.GetAxisRaw("Horizontal") < 0? -speed : 0, jump && rb.gameObject.GetComponent<GroundCheck>().OnGround ? jumpHeight : rb.velocity.y, 0);
            rb.velocity = velocity;
        }
    }
}
