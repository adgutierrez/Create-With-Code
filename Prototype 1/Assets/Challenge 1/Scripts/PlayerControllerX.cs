using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    public float rotationSpeed = 25.0f;
    public float verticalInput;
    public float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(verticalInput * rotationSpeed * Time.deltaTime * Vector3.left);
        transform.Rotate(horizontalInput * rotationSpeed * Time.deltaTime * Vector3.forward);
        // transform.Rotate(horizontalInput * rotationSpeed * Time.deltaTime * Vector3.up);
    }
}
