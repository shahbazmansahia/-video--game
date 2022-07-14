using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float forwardInput;
    public float speed = 0.5f;
    public float walkForce = 0.5f;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        // gets the rigidbody object attached to player gameObject
        playerRb = GetComponent<Rigidbody>();   
    }

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //playerRb.AddRelativeForce(Vector3.forward * forwardInput * walkForce);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        //transform.(Vector3.forward, Time.deltaTime * speed * forwardInput);
    }

    // Update is called once per frame
    void Update()
    {
        // TO DO: Add sound and optional rumble fx as you walk
    }

    private void OnCollisionEnter(Collision collision)
    {
        // TO DO: Add collision interaction with walls and objects
    }
}
