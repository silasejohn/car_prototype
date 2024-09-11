using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // getting user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the Vehicle Forward
        // adding time.deltaTime (change in time between all frames, standardizes frames accross diff computers)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // controls turning
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        

    }
}
