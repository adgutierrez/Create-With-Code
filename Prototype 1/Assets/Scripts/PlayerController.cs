using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // vaariables for move, turn and Input control
    public float moveSpeed = 15.0f;
    public float turnSpeed = 10.0f;
    public float truningInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get control input from player
        truningInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We will move the vehicle forward
        transform.Translate(forwardInput * moveSpeed * Time.deltaTime * Vector3.forward);
        transform.Rotate(truningInput * turnSpeed * Time.deltaTime * Vector3.up);
    }
}
